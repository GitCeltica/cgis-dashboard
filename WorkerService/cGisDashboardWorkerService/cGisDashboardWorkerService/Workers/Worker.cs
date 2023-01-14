using cGisDashboardWorkerService.Helpers.Debug;
using cGisDashboardWorkerService.Workers.Indicadores.Interfaces;

namespace cGisDashboardWorkerService.Workers
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IDadosTecnicos _dadosTecnicos;

        public DebugInfoResult result;

        public Worker(ILogger<Worker> logger, IDadosTecnicos dadosTecnicos)
        {
            _logger = logger;
            _dadosTecnicos= dadosTecnicos;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                result = await _dadosTecnicos.ProcessaDadosTecnicos();

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogInformation($"{result.Dados}");
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}