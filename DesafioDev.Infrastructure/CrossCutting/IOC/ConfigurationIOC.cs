using Autofac;
using DesafioDev.Application;
using DesafioDev.Application.Interfaces;
using DesafioDev.Application.Interfaces.Mappers;
using DesafioDev.Application.Mappers;
using DesafioDev.Domain.Core.Interfaces.Repositorys;
using DesafioDev.Domain.Core.Interfaces.Services;
using DesafioDev.Domain.Services;
using DesafioDev.Infrastructure.Data.Repositorys;

namespace DesafioDev.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceFornecedor>().As<IApplicationServiceFornecedor>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceFornecedor>().As<IServiceFornecedor>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryFornecedor>().As<IRepositoryFornecedor>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperFornecedor>().As<IMapperFornecedor>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
        }
    }
}