﻿using POS.Domain.Entities;
using System.Linq.Expressions;

namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IGenericRepository<T> where T :BaseEntity
    {
        IQueryable<T> GetAllQueryble();
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetSelectAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> RegisterAsync(T entity);
        Task<bool> EditAsync(T entity);
        Task<bool> RemoveAsync(int id);
        IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null);
    }
}
