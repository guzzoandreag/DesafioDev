using DesafioDev.Domain.Entitys;
using System.Collections.Generic;

namespace DesafioDev.Domain.Core.Interfaces.Services
{
    public interface IServiceProduto : IServiceBase<Produto>
    {
        IEnumerable<Produto> GetAll(int skip, int take, string pro_nome);
    }
}