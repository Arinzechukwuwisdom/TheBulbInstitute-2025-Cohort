using TodoList.Models;
using TodoList.Utils;

namespace TodoList.Interfaces
{
    public interface ITodoItemService : IBaseService<TodoItem>
    {
        Task<ResponseModel<TodoItem>> Create(TodoItem entity, int userId);
        Task<ResponseModel<TodoItem>> Update(TodoItem entity, int id, int userId);
        Task<List<TodoItem>> GetAll(int userId);
        Task<ResponseModel<TodoItem>> GetById(int id, int userId);
        Task<bool> Delete(int id, int userId);
    }
}
