﻿using parola.Entities;
using parola.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace parola.Database.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}