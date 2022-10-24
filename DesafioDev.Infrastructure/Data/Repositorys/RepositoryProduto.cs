using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Entitys;
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
    }
}