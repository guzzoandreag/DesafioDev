using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Core.Interfaces.Services;
using DesafioDev.Domain.Entitys;
using System;
using System.Collections.Generic;

namespace DesafioDev.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }

        public IEnumerable<Produto> GetAll(int skip, int take, string pro_nome)
        {
            return repositoryProduto.GetAll(skip, take, pro_nome);
        }
    }
}