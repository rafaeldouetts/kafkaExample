// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Kafka.Producer.Console;

Console.WriteLine("Hello, World!");

IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services => {
    services.AddHostedService<ProducerService>();
}).Build();



await host.RunAsync();