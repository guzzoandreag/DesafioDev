using DesafioDev.Application.DTOs;
using DesafioDev.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        ProdutoDto MapperEntityToDto(Produto produto);

        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);
    }
}
