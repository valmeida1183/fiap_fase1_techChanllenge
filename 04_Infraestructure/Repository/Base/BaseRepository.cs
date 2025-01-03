using Core.Entity.Base;
using Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Configuration;

namespace Infraestructure.Repository.Base;
public class BaseRepository<T> : IRepository<T> where T : EntityBase
{
    protected DataContext _context;
    protected DbSet<T> _dbSet;

    public BaseRepository(DataContext dataContext)
    {
        _context = dataContext;
        _dbSet = _context.Set<T>();
    }

    public void Create(T entity)
    {
        entity.CreatedOn = DateTime.UtcNow;

        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _dbSet.FirstOrDefault(x => x.Id == id);

        if (entity is null)
            return;

        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public void Edit(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public IList<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return _dbSet.FirstOrDefault(x => x.Id == id);
    }
}
