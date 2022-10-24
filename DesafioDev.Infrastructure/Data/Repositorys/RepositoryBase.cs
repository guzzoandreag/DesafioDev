using DesafioDev.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDev.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                dataContext.Set<TEntity>().Add(entity);
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll(int skip,int take)
        {
            return dataContext.Set<TEntity>().Skip<TEntity>(skip).Take<TEntity>(take).ToList();
        }

        public TEntity GetById(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }

        public virtual void Delete(TEntity entity)
        {
            try
            {               
                dataContext.Set<TEntity>().Remove(entity);
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}