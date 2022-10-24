using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDev.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly DataContext dataContext;

        public RepositoryProduto(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Produto> GetAll(int skip, int take, string pro_nome)
        {
            if (pro_nome == null)
            {
                return dataContext.Set<Produto>().Skip<Produto>(skip).Take<Produto>(take).ToList();                
            }
            else
            {
                return dataContext.Set<Produto>().Skip<Produto>(skip).Take<Produto>(take).Where<Produto>(x => x.pro_nome == pro_nome).ToList();
            }            
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