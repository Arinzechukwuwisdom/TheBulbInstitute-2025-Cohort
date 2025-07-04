using TodoList.Utils;

namespace TodoList.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<ResponseModel<T>> GetById(int id);
        Task<ResponseModel<T>> Create(T entity);
        Task<ResponseModel<T>> Update(T entity, int id);
        Task<bool> Delete(int id);
    }
}
