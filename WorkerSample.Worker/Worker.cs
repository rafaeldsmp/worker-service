using Application;
using Microsoft.Extensions.Configuration;

namespace WorkerSample
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _provider;
        private readonly IConfiguration _configuration;
        private readonly NLog.ILogger _logger;

        public Worker(IServiceProvider provider, IConfiguration configuration, NLog.ILogger logger)
        {
            _provider = provider;
            _configuration = configuration;
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Info("Starting Service - Eletronicos");
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (IServiceScope scope = _provider.CreateScope())
                {
                    var product = scope.ServiceProvider.GetRequiredService<ProductApplication>();
                    product.GetAllEletronicosUserAndInsert();
                }
                await Task.Delay(_configuration.GetValue<int>("Time:Week"), stoppingToken);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Info("Service Ending - Eletronicos");
            return base.StopAsync(cancellationToken);
        }
    }
}