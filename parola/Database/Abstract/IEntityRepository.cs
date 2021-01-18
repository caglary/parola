using parola.Entities;
using parola.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace parola.Database.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
