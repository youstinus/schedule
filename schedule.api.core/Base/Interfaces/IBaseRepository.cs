﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace schedule.api.core.Base.Interfaces
{
    public interface IBaseRepository<T> where T: IBaseEntity
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(long id);
        Task<T> Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetSingleByPredicate(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> GetAllByPredicate(Expression<Func<T, bool>> predicate);
    }
}
