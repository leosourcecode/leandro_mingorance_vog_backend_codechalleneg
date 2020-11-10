using Application.Repositories;
using Infrastructure.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext db;

        public BaseRepository(ApiContext context) =>
            db = context;

        public virtual TEntity Save(TEntity obj)
        {
            var entity = db.Add(obj);
            db.SaveChanges();

            return obj;
        }

        public virtual IEnumerable<TEntity> GetAll() =>
            db.Set<TEntity>().ToList();

        public virtual TEntity GetById(int? id)
        {
            return db.Set<TEntity>().Find(id);
        }


        public virtual void Delete(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        private bool _disposed = false;

        ~BaseRepository() =>
            Dispose();

        public void Dispose()
        {
            if (!_disposed)
            {
                db.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
