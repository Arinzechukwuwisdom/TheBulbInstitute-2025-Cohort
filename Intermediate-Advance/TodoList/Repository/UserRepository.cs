using Microsoft.EntityFrameworkCore;
using TodoList.DataContext;
using TodoList.Interfaces;
using TodoList.Models;
using TodoList.Utils;

namespace TodoList.Repository
{
    public class UserRepository : IUserService
    {
        private readonly TodoContext todoContext = new TodoContext();
        public async Task<ResponseModel<User>> Create(User param)
        {
            try
            {
                var userExists = await todoContext.Users.AnyAsync(u => u.Email == param.Email);
                if (userExists)
                {
                    return ResponseModel<User>.Failed("Conflict", "Email already exists", 409);
                }
                if (string.IsNullOrWhiteSpace(param.Name) || string.IsNullOrWhiteSpace(param.Email))
                {
                    return ResponseModel<User>.Failed("Bad Request", "Email and/or Name is empty", 400);
                }
                if (param.Age < 18 || param.Age > 50)
                {
                    return ResponseModel<User>.Failed("Bad Request", "Age must be between 18 and 50", 400);
                }
                var res = await todoContext.Users.AddAsync(param);
                await todoContext.SaveChangesAsync();
                return ResponseModel<User>.Success(res.Entity, "User created successfully", 201);
            }
            catch (Exception ex)
            {
                return ResponseModel<User>.Failed(ex.Message, "An error occurred while creating the user");
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var user = await todoContext.Users.FindAsync(id);
                if (user is null)
                {
                    throw new ArgumentNullException($"User with ID {id} not found.");
                }
                todoContext.Users.Remove(user);
                await todoContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the user with ID {id}: {ex.Message}");
            }
        }

        public async Task<List<User>> GetAll()
        {
            try
            {
                var users = await todoContext.Users.Include(u => u.TodoItems).ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving all users: {ex.Message}");
            }
        }

        public async Task<ResponseModel<User>> GetById(int id)
        {
            try
            {
                var user = await todoContext.Users.Include(u => u.TodoItems).FirstOrDefaultAsync(u => u.Id == id);
                if (user is null)
                {
                    return ResponseModel<User>.Failed("Not Found", $"User with ID {id} not found", 404);
                }
                return ResponseModel<User>.Success(user, "User retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<User>.Failed("", ex.Message);
            }
        }

        public async Task<ResponseModel<User>> Update(User entity, int userId)
        {
            try
            {
                var user = await todoContext.Users.FindAsync(userId);
                if (user is null)
                {
                    return ResponseModel<User>.Failed("Not Found", $"User with ID {userId} not found", 404);
                }
                user.Name = entity.Name ?? user.Name;
                user.Email = string.IsNullOrEmpty(entity.Email) ? user.Email : entity.Email;
                user.Age = entity.Age > 0 ? entity.Age : user.Age;

                var userExists = await todoContext.Users.AnyAsync(u => u.Email == user.Email && u.Id != userId);
                if (userExists)
                {
                    return ResponseModel<User>.Failed("Conflict", "Email already exists", 409);
                }

                var res = todoContext.Update(user);
                await todoContext.SaveChangesAsync();
                return ResponseModel<User>.Success(res.Entity, "User updated successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<User>.Failed("Internal server error", ex.Message, ex.HResult);
            }
        }
    }
}
