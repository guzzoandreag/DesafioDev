using DesafioDev.Application.DTOs;
using System.Collections.Generic;

namespace DesafioDev.Application.Interfaces
{
    public interface IApplicationServiceFornecedor
    {
        void Add(FornecedorDto fornecedorDto);

        void Update(FornecedorDto fornecedorDto);

        void Delete(FornecedorDto fornecedorDto);

        IEnumerable<FornecedorDto> GetAll(int skip, int take);

        FornecedorDto GetById(int id);
    }
}