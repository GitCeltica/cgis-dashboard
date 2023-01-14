using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Workers.Interfaces;
using System.Threading;


namespace cGisDashBoard.Workers
{
    public class BackgroundWorkerService : BackgroundService
    {
        private readonly ILogger<BackgroundWorkerService> _logger;
        private readonly IIndicadoresWorkerService _workerService;

        public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger, IIndicadoresWorkerService workerService)
        {
            _logger = logger;

            _workerService = workerService;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Servive started");

            return Task.CompletedTask;

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Service stopped");
            
            return Task.CompletedTask;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var result = await _workerService.ProcessaIndicadores();
                _logger.LogInformation($" Username: {result.Username} Worker running at {DateTime.Now}");

                //await Task.Delay(60000, stoppingToken); //1 minuto
                await Task.Delay(5000, stoppingToken); //5 seg
            }
        }
    }
}
