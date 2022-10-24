using DesafioDev.Application.DTOs;
using DesafioDev.Domain.Entitys;
using System.Collections.Generic;

namespace DesafioDev.Application.Interfaces.Mappers
{
    public interface IMapperFornecedor
    {
        Fornecedor MapperDtoToEntity(FornecedorDto fornecedorDto);

        FornecedorDto MapperEntityToDto(Fornecedor fornecedor);

        IEnumerable<FornecedorDto> MapperListFornecedorDto(IEnumerable<Fornecedor> fornecedores);        
    }
}
