using Jr.Backend.Pedidos.Infrastructure.Entity;
using Jr.Backend.Pedidos.Infrastructure.Interfaces;
using Jr.Backend.Pedidos.Infrastructure.Repository.MongoDb;
using Jror.Backend.Libs.Infrastructure.MongoDB.Abstractions;
using Jror.Backend.Libs.Infrastructure.MongoDB.Abstractions.Interfaces;
using Jror.Backend.Libs.Infrastructure.MongoDB.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Jr.Backend.Pedidos.Infrastructure.DependencyInjection
{
    public static class ServicesDependency
    {
        public static void AddServiceDependencyInfrastructure(this IServiceCollection services)
        {
            services.AddServiceDependencyJrorInfrastructureMongoDb(ConnectionType.DirectConnection);

            services.AddScoped<IPessoaRepository>((p) =>
            {
                var mongoContext = p.GetService<IMongoContext>();
                return new PessoaRepository(mongoContext, typeof(Pessoa).Name);
            });
        }
    }
}