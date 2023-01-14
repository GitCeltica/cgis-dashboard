using Microsoft.EntityFrameworkCore;
using WebApiDashboardSaneamento.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();

builder.Services.AddDbContext<DashBoardDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DashBoardDbConnectionString")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*");
                      });
});

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/", () => "Bem vindo ao Dashboard do cGIS Saneamento!");

app.MapGet("/indicadores", async (DashBoardDbContext db) =>
    await db.IndicadoresPerdas.ToListAsync());

app.MapGet("/indicadores/{cidadeid}", async (int cidadeid, DashBoardDbContext db) =>
    await db.IndicadoresPerdas.Where(t => t.CidadeId == cidadeid).ToListAsync());

app.MapPost("/indicadores", async (Parametros obj, DashBoardDbContext db) =>
{
    List<IndicadoresPerdas> dadosIndicadores  = await db.IndicadoresPerdas.ToListAsync();

    if (obj.CidadeId != 0)
        dadosIndicadores = dadosIndicadores.Where(t => t.CidadeId == obj.CidadeId).ToList();

    if (obj.Ano != 0)
        dadosIndicadores = dadosIndicadores.Where(t => t.Ano == obj.Ano).ToList();

    if (obj.Mes != 0)
        dadosIndicadores = dadosIndicadores.Where(t => t.Mes == obj.Mes).ToList();

    if (obj.Regiao != "")
        dadosIndicadores = dadosIndicadores.Where(t => t.Regiao == obj.Regiao).ToList();

    return dadosIndicadores;
});
    

app.Run();

public class Parametros
{
    public int CidadeId { get; set; }    
    public int Mes { get; set; }
    public int Ano { get; set; }
    public string? Regiao { get; set; }
}
