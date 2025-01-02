using Core.Entity.Base;

namespace Core.Repository.Interface;
public interface IRepository<T> where T : EntityBase
{
    IList<T> GetAll();
    T? GetById(int id);
    void Create(T entity);
    void Edit(T entity);
    void Delete(int id);
}
