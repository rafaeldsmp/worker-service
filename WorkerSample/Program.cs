using Autofac;
using Autofac.Extensions.DependencyInjection;
using WorkerSample;
using WorkerSample.Domain.IRepository;
using WorkerSample.Infrastructure.Data;
using WorkerSample.Infrastructure.Repository;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>((builder) =>
    {
        builder.Register(componentContext =>
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var option = new DapperContext(configuration);//TODO: RETIRAR A CHAMADA
            return option;
        }).InstancePerLifetimeScope();
        builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
    })
    
    .Build();

await host.RunAsync();
