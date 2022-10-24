using System.Collections.Generic;

namespace DesafioDev.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll(int skip, int take);

        TEntity GetById(int id);
    }
}