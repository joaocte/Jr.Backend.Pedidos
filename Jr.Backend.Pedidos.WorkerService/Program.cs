using Jr.Backend.Pedidos.Infrastructure.DependencyInjection;
using Jr.Backend.Pedidos.WorkerService.DependencyInjection;
using Jr.Backend.Pessoa.Application.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace Jr.Backend.Pedidos.WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?.ToLowerInvariant();

            var config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: false)
                                .AddEnvironmentVariables()
                                .Build();

            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddServiceDependencyApplication();
                    services.AddServiceDependencyInfrastructure();
                    services.AddServiceDependencyWorkerService(config);
                });
        }
    }
}