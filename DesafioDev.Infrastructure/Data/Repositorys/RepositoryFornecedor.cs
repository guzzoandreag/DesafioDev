using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Entitys;

namespace DesafioDev.Infrastructure.Data.Repositorys
{
    public class RepositoryFornecedor : RepositoryBase<Fornecedor>, IRepositoryFornecedor
    {
        private readonly DataContext dataContext;

        public RepositoryFornecedor(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}