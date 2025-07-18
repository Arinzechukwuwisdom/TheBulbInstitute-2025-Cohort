using LibraryManagementSystem.DataContext;
using LibraryManagementSystem.DTOs.User;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class UserRepository(LibraryContext context) : IUserService
    {
        private readonly LibraryContext dbContext = context;
        //private readonly IMapper mapper = mapper;

        public async Task<ResponseModel<GetUserDTO>> CreateUser(CreateUserDTO userDetail)
        {
            try
            {
                var userExists = await dbContext.Users.AnyAsync(u => u.Email == userDetail.Email);
                if (userExists)
                {
                    return ResponseModel<GetUserDTO>.Failed("Conflict", $"User with email: {userDetail.Email} already exist", 409);
                }
                var lastMembershipNumber = await dbContext.Users
                    .Select(u => u.MembershipNumber)
                    .MaxAsync();

                var user = new User
                {
                    Email = userDetail.Email.ToLower(),
                    Name = userDetail.Name.ToUpper(),
                    MembershipNumber = lastMembershipNumber + 1,
                    Password = BCrypt.Net.BCrypt.HashPassword(userDetail.Password),
                    Address = userDetail.Address.ToLower()
                };

                await dbContext.Users.AddAsync(user);
                await dbContext.SaveChangesAsync();

                var userDTO = new GetUserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    MembershipCode = user.MembershipCode,
                    Address = user.Address,
                    CreatedAt = user.CreatedAt,
                    UpdatedAt = user.UpdatedAt
                };

                return ResponseModel<GetUserDTO>.Success(userDTO, "User created successfully", 201);
            }
            catch (Exception ex)
            {
                return ResponseModel<GetUserDTO>.Failed("Caught Exception", ex.Message, ex.HResult);
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var user = await dbContext.Users.FindAsync(id);
                if (user == null)
                {
                    return false;
                }
                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ResponseModel<List<GetUserDTO>>> GetAllUsers()
        {
            try
            {
                var users = await dbContext.Users
                    .OrderBy(u => u.MembershipNumber)
                    .Select(u => new GetUserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        Email = u.Email,
                        MembershipCode = u.MembershipCode,
                        Address = u.Address,
                        CreatedAt = u.CreatedAt,
                        UpdatedAt = u.UpdatedAt
                    })
                    .ToListAsync();
                if (users.Count == 0)
                {
                    return ResponseModel<List<GetUserDTO>>.Success([], "No users found", 204);
                }
                return ResponseModel<List<GetUserDTO>>.Success(users, "Users retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<List<GetUserDTO>>.Failed("Caught Exception", ex.Message, ex.HResult);
            }
        }

        public async Task<ResponseModel<GetUserDTO>> GetUserByID(Guid id)
        {
            try
            {
                var user = await dbContext.Users.FindAsync(id);
                if (user is null)
                {
                    return ResponseModel<GetUserDTO>.Failed("Not Found", $"User with ID: {id} does not exist", 404);
                }
                var userDTO = new GetUserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    MembershipCode = user.MembershipCode,
                    Address = user.Address,
                    CreatedAt = user.CreatedAt,
                    UpdatedAt = user.UpdatedAt
                };
                return ResponseModel<GetUserDTO>.Success(userDTO, "User retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<GetUserDTO>.Failed("Caught Exception", ex.Message, ex.HResult);
            }
        }

        public async Task<ResponseModel<GetUserDTO>> UpdateUser(CreateUserDTO userDetails, Guid id)
        {
            try
            {
                var user = await dbContext.Users.FindAsync(id);
                if (user is null)
                {
                    return ResponseModel<GetUserDTO>.Failed("Not Found", $"User with ID: {id} does not exist", 404);
                }
                var emailExists = await dbContext.Users.AnyAsync(u => u.Email == userDetails.Email && u.Id != id);
                if (emailExists)
                {
                    return ResponseModel<GetUserDTO>.Failed("Conflict", $"User with email: {userDetails.Email} already exists", 409);
                }
                user.Name = userDetails.Name.ToUpper() ?? user.Name;
                user.Email = userDetails.Email.ToLower() ?? user.Email;
                user.Address = userDetails.Address.ToUpper() ?? user.Address;
                user.Password = userDetails.Password is not null
                    ? BCrypt.Net.BCrypt.HashPassword(userDetails.Password)
                    : user.Password;
                user.UpdatedAt = DateTimeOffset.UtcNow;

                dbContext.Users.Update(user);
                await dbContext.SaveChangesAsync();

                var result = new GetUserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    MembershipCode = user.MembershipCode,
                    Address = user.Address,
                    CreatedAt = user.CreatedAt,
                    UpdatedAt = user.UpdatedAt
                };
                return ResponseModel<GetUserDTO>.Success(result, "User updated successfully", 200);

            }
            catch (Exception ex)
            {
                return ResponseModel<GetUserDTO>.Failed("Caught Exception", ex.Message, ex.HResult);
            }
        }
    }
}
