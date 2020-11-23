using parola.Database.Abstract;
using parola.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace parola.Database.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, Tcontext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where Tcontext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public virtual void Update(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
