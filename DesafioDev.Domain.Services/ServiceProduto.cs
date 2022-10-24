using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Core.Interfaces.Services;
using DesafioDev.Domain.Entitys;
using System;

namespace DesafioDev.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }

        //public void Save(int pro_codigo, string pro_nome, bool pro_situacao, DateTime pro_datafabricacao, DateTime pro_datavalidade, int for_codigo)
        //{
        //    var produto = repositoryProduto.GetById(pro_codigo);
        //    if (produto == null)
        //    {
        //        produto = new Produto(pro_codigo, pro_nome, pro_situacao, pro_datafabricacao, pro_datavalidade, for_codigo);
        //        repositoryProduto.Add(produto);
        //    }
        //    else
        //        produto.Update(pro_datafabricacao, pro_datavalidade);
        //}
    }
}