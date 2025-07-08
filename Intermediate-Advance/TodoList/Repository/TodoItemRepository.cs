using Microsoft.EntityFrameworkCore;
using TodoList.DataContext;
using TodoList.Interfaces;
using TodoList.Models;
using TodoList.Utils;

namespace TodoList.Repository
{
    public class TodoItemRepository : ITodoItemService
    {
        private readonly TodoContext todoContext = new TodoContext();
        #region Tai
        public Task<ResponseModel<TodoItem>> Create(TodoItem entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<TodoItem>> Create(TodoItem entity, int userId)
        {
            try
            {
                var user = await todoContext.Users.FindAsync(userId);
                if (user is null)
                {
                    return ResponseModel<TodoItem>.Failed("Not Found", $"User with ID {userId} not found", 404);
                }

                var todoItem = new TodoItem
                {
                    Title = entity.Title,
                    Description = entity.Description,
                    UserId = userId,
                    IsCompleted = false
                };

                //await todoContext.TodoItems.AddAsync(todoItem);
                user.TodoItems.Add(todoItem);
                await todoContext.SaveChangesAsync();
                return ResponseModel<TodoItem>.Success(todoItem, "TodoItem created successfully", 201);

            }
            catch (Exception ex)
            {
                return ResponseModel<TodoItem>.Failed(ex.Message, "An error occurred while creating the TodoItem");
            }
        }
        #endregion

        #region Arinze
        /// <summary>
        /// Arinze is doing this part
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> Delete(int id)
        {
            try
            {
                var todoItem = await todoContext.TodoItems.FindAsync(id);
                if (todoItem is null)
                {
                    throw new ArgumentNullException($"TodoItem with ID {id} not found.");
                }
                todoContext.TodoItems.Remove(todoItem);
                await todoContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the TodoItem with ID {id}: {ex.Message}");
            }
        }

        public Task<bool> Delete(int id, int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TodoItem>> GetAll()
        {
            try
            {
                return await todoContext.TodoItems.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving all TodoItems: {ex.Message}");
            }
        }

        public async Task<List<TodoItem>> GetAllByUserId(int userId)
        {
            try
            {
                //var todoItems = await todoContext.TodoItems
                //    .Where(t => t.UserId == userId)
                //    .ToListAsync();

                //var todoItems = await todoContext.Users.Include(u => u.TodoItems)
                //    .Where(u => u.Id == userId)
                //    .SelectMany(u => u.TodoItems)
                //    .ToListAsync();

                var user = await todoContext.Users.Include(u => u.TodoItems).FirstOrDefaultAsync(u => u.Id == userId);
                var todoItems = user.TodoItems.ToList();
                return todoItems;

            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving TodoItems for User ID {userId}: {ex.Message}");
            }
        }

        public async Task<ResponseModel<TodoItem>> GetById(int id)
        {
            try
            {
                var todoItem = await todoContext.TodoItems.FindAsync(id);
                if (todoItem is null)
                {
                    return ResponseModel<TodoItem>.Failed("Not Found", $"TodoItem with ID {id} not found", 404);
                }
                return ResponseModel<TodoItem>.Success(todoItem, "TodoItem retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<TodoItem>.Failed(ex.Message, "An error occurred while retrieving the TodoItem");
            }
        }

        public async Task<ResponseModel<TodoItem>> GetById(int id, int userId)
        {
            try
            {
                //var todoItem = await todoContext.TodoItems
                //    .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

                var todoItem = await todoContext.TodoItems.Where(t => t.UserId == userId)
                    .FirstOrDefaultAsync(t => t.Id == id);

                //var user = await todoContext.Users
                //    .Include(u => u.TodoItems)
                //    .FirstOrDefaultAsync(u => u.Id == userId);
                //if (user is null)
                //{
                //    return ResponseModel<TodoItem>.Failed("Not Found", $"User with ID {userId} not found", 404);
                //}
                //var todoItem = user.TodoItems.FirstOrDefault(t => t.Id == id);

                if (todoItem is null)
                {
                    return ResponseModel<TodoItem>.Failed("Not Found", $"TodoItem with ID {id} for User ID {userId} not found", 404);
                }
                return ResponseModel<TodoItem>.Success(todoItem, "TodoItem retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ResponseModel<TodoItem>.Failed(ex.Message, "An error occurred while retrieving the TodoItem");
            }
        }

        #endregion

        #region Claudius
        public Task<ResponseModel<TodoItem>> Update(TodoItem entity, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<TodoItem>> Update(TodoItem entity, int id, int userId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
