using DesafioDev.Application.DTOs;
using DesafioDev.Application.Interfaces;
using DesafioDev.Application.Interfaces.Mappers;
using DesafioDev.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Application
{
    public class ApplicationServiceFornecedor : IApplicationServiceFornecedor
    {
        private readonly IServiceFornecedor serviceFornecedor;
        private readonly IMapperFornecedor mapperFornecedor;

        public ApplicationServiceFornecedor(IServiceFornecedor serviceFornecedor, IMapperFornecedor mapperFornecedor)
        {
            this.serviceFornecedor = serviceFornecedor;
            this.mapperFornecedor = mapperFornecedor;
        }

        public void Add(FornecedorDto fornecedorDto)
        {
            var fornecedor = mapperFornecedor.MapperDtoToEntity(fornecedorDto);
            serviceFornecedor.Add(fornecedor);
        }

        public IEnumerable<FornecedorDto> GetAll(int skip, int take)
        {
            var fornecedores = serviceFornecedor.GetAll(skip, take);
            return mapperFornecedor.MapperListFornecedorDto(fornecedores);
        }

        public FornecedorDto GetById(int id)
        {
            var fornecedor = serviceFornecedor.GetById(id);
            return mapperFornecedor.MapperEntityToDto(fornecedor);
        }

        public void Delete(FornecedorDto fornecedorDto)
        {
            var fornecedor = mapperFornecedor.MapperDtoToEntity(fornecedorDto);
            serviceFornecedor.Delete(fornecedor);
        }

        public void Update(FornecedorDto fornecedorDto)
        {
            var fornecedor = mapperFornecedor.MapperDtoToEntity(fornecedorDto);
            serviceFornecedor.Update(fornecedor);
        }
    }
}