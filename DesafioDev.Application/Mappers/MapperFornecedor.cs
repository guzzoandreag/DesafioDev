using AutoMapper;
using DesafioDev.Application.DTOs;
using DesafioDev.Application.Interfaces.Mappers;
using DesafioDev.Domain.Entitys;
using System.Collections.Generic;

namespace DesafioDev.Application.Mappers
{
    public class MapperFornecedor : IMapperFornecedor
    {
        private IMapper mapper { get; set; }

        public MapperFornecedor()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Fornecedor, FornecedorDto>();
                cfg.CreateMap<FornecedorDto, Fornecedor>();
            });

            this.mapper = configuration.CreateMapper();
        }

        public Fornecedor MapperDtoToEntity(FornecedorDto fornecedorDto)
        {
            var fornecedor = mapper.Map<Fornecedor>(fornecedorDto);
            return fornecedor;
        }

        public FornecedorDto MapperEntityToDto(Fornecedor fornecedor)
        {
            var fornecedorDto = mapper.Map<FornecedorDto>(fornecedor);
            return fornecedorDto;
        }

        public IEnumerable<FornecedorDto> MapperListFornecedorDto(IEnumerable<Fornecedor> fornecedores)
        {
            var fornecedoresDto = mapper.Map<IEnumerable<FornecedorDto>>(fornecedores);
            return fornecedoresDto;
        }
    }
}
