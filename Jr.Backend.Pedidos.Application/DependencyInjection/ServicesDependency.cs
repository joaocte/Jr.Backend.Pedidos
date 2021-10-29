using AutoMapper;
using Jr.Backend.Pedidos.Application.AutoMapper;
using Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa;
using Microsoft.Extensions.DependencyInjection;

namespace Jr.Backend.Pessoa.Application.DependencyInjection
{
    public static class ServicesDependency
    {
        public static void AddServiceDependencyApplication(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfileToDomain());
                mc.AddProfile(new MappingProfileToEntity());
                mc.AddProfile(new MappingProfileToEnvent());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<ICadastrarPessoaUseCase, CadastrarPessoaUseCase>();
        }
    }
}