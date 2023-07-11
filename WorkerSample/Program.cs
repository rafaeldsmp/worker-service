using Application;
using Application.IService;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using NLog;
using NLog.Extensions.Logging;
using WorkerSample;
using WorkerSample.Domain.IRepository;
using WorkerSample.Infrastructure.Data;
using WorkerSample.Infrastructure.Repository;
using ILogger = NLog.ILogger;

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
        builder.RegisterType<ProductApplication>().As<IProductApplication>().AsSelf();
        builder.RegisterInstance(LogManager.GetCurrentClassLogger()).As<ILogger>().As<Logger>().SingleInstance();
    })
    
    .ConfigureLogging((ctx, logging)=>
    {
        logging.ClearProviders();
        logging.AddNLog(ctx.Configuration, new NLogProviderOptions()
        {
            LoggingConfigurationSectionName = "NLog"
        });
    })
    .Build();

await host.RunAsync();
