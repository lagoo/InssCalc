using ConsoleApp.Implementations;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var service = host.Services.GetService<ICalculadorInss>();

            service.CalcularDesconto(new DateTime(2012, 1, 1), 1500);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<InssConfig>(options => hostContext.Configuration.GetSection("InssConfig").Bind(options));

                    services.AddScoped<ICalculadorInss, CalculadorInss>();  
                    services.AddScoped<IAliquotService, AliquotService>();
                });
    }
}
