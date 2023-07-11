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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
              using (IServiceScope scope = _provider.CreateScope())
                {
                   // var product = scope.ServiceProvider.GetRequiredService<"aplication here">

                }
            }
        }
    }
}