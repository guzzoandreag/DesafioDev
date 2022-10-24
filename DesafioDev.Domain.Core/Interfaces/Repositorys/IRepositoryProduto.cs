using DesafioDev.Domain.Entitys;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioDev.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryProduto : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> GetAll(int skip, int take, string pro_nome);
    }
}