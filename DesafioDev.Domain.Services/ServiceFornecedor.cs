using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Core.Interfaces.Services;
using DesafioDev.Domain.Entitys;

namespace DesafioDev.Domain.Services
{
    public class ServiceFornecedor : ServiceBase<Fornecedor>, IServiceFornecedor
    {
        private readonly IRepositoryFornecedor repositoryFornecedor;

        public ServiceFornecedor(IRepositoryFornecedor repositoryFornecedor) : base(repositoryFornecedor)
        {
            this.repositoryFornecedor = repositoryFornecedor;
        }
    }
}