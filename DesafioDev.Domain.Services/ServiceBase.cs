using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace DesafioDev.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll(int skip, int take)
        {
            return repository.GetAll(skip, take);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}