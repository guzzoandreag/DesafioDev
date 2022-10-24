using DesafioDev.Application.DTOs;
using System.Collections.Generic;

namespace DesafioDev.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Delete(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll(int skip, int take, string pro_nome);

        ProdutoDto GetById(int id);
    }
}