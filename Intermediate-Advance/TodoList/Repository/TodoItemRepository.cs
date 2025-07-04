using TodoList.Interfaces;
using TodoList.Models;
using TodoList.Utils;

namespace TodoList.Repository
{
    public class TodoItemRepository : ITodoItemService
    {
        #region Tai
        public Task<ResponseModel<TodoItem>> Create(TodoItem entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Arinze
        /// <summary>
        /// Arinze is doing this part
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<TodoItem>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Claudius
        public Task<ResponseModel<TodoItem>> Update(TodoItem entity, int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
