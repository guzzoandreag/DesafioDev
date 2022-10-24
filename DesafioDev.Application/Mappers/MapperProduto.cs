using AutoMapper;
using AutoMapper.Configuration;
using DesafioDev.Application.DTOs;
using DesafioDev.Application.Interfaces.Mappers;
using DesafioDev.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        private IMapper mapper { get; set; }

        public MapperProduto()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoDto>();
                cfg.CreateMap<ProdutoDto, Produto>();
            });

            this.mapper = configuration.CreateMapper();
        }

        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = mapper.Map<ProdutoDto>(produto);
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos)
        {
            var produtosDto = mapper.Map<IEnumerable<ProdutoDto>>(produtos);
            return produtosDto;
        }
    }
}
