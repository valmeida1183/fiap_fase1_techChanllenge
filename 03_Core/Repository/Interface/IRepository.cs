﻿using Core.Entity.Base;

namespace Core.Repository.Interface;
public interface IRepository<T> where T : EntityBase
{
    Task<IList<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task EditAsync(T entity);
    Task DeleteAsync(int id);
}
