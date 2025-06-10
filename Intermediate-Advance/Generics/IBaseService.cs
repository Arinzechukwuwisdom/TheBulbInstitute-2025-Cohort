namespace Generics
{
    public interface IBaseService<T>
    {
        ResponseDetail<T> Create(T entity);
        ResponseDetail<T> Update(T entity);
        ResponseDetail<T> Delete(T entity);
        ResponseDetail<T> GetById(int id);
        ResponseDetail<List<T>> GetAll();
        ResponseDetail<List<T>> Search(string searchTerm);

    }
}
