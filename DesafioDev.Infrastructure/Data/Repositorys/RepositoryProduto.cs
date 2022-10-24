using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DesafioDev.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly DataContext dataContext;

        public RepositoryProduto(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public override void Delete(Produto entity)
        {
            try
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                //dataContext.Set<TEntity>().Remove(entity);
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}