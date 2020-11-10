using System;
using System.Collections.Generic;

namespace Application.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Save(TEntity obj);
        TEntity GetById(int? id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
    }
}
