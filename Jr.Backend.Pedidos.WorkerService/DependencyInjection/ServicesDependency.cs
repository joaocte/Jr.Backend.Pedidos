using GreenPipes;
using Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa;
using Jr.Backend.Pedidos.Application.UseCases.DeletarPessoa;
using Jr.Backend.Pedidos.Infrastructure.DependencyInjection;
using Jr.Backend.Pessoa.Application.DependencyInjection;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Jr.Backend.Pedidos.WorkerService.DependencyInjection
{
    public static class ServicesDependency
    {
        public static void AddServiceDependencyWorkerService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddServiceDependencyApplication();
            services.AddServiceDependencyInfrastructure();
            services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cfg =>
                 {
                     cfg.Host(new Uri(configuration["RabbitSetting:UriBase"]), h =>
                     {
                         h.Username(configuration["RabbitSetting:User"]);
                         h.Password(configuration["RabbitSetting:Password"]);
                     });

                     cfg.ReceiveEndpoint("PessoaCadastradaEvent", ep =>
                     {
                         ep.PrefetchCount = 10;
                         ep.UseMessageRetry(r => r.Interval(2, 100));
                         ep.Consumer<CadastrarPessoaValidationUseCase>(provider);
                     });
                     cfg.ReceiveEndpoint("PessoaDeletadaEvent", ep =>
                     {
                         ep.PrefetchCount = 10;
                         ep.UseMessageRetry(r => r.Interval(2, 100));
                         ep.Consumer<DeletarPessoaValidationUseCase>(provider);

                     });
                 }));
                x.AddConsumer<CadastrarPessoaValidationUseCase>();
                x.AddConsumer<DeletarPessoaValidationUseCase>();
            });
            services.AddMassTransitHostedService();
        }
    }
}