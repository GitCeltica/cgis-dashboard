using cGisDashboardWorkerService.Workers;
using cGisDashboardWorkerService.Workers.Indicadores;
using cGisDashboardWorkerService.Workers.Indicadores.Interfaces;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IDadosTecnicos, DadosTecnicos>();
    })
    .Build();

await host.RunAsync();
