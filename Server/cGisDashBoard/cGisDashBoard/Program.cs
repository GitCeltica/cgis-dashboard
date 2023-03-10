using cGisDashBoard.Helpers.Auth;
using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories;
using cGisDashBoard.Repositories.Indicadores;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services;
using cGisDashBoard.Services.Indicadores;
using cGisDashBoard.Services.Interfaces;
using cGisDashBoard.Services.Interfaces.Indicadores;
using cGisDashBoard.Workers;
using cGisDashBoard.Workers.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHostedService<BackgroundWorkerService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*");
                      });
});

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    builder => builder.EnableRetryOnFailure()));


builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
builder.Services.AddScoped<IIndicadoresRepository, IndicadoresRepository>();
builder.Services.AddScoped<IDadosTecnicosRepository, DadosTecnicosRepository>();
builder.Services.AddScoped<IDadosConsumoRepository, DadosConsumoRepository>();
builder.Services.AddScoped<IDadosLigacoesRepository, DadosLigacoesRepository>();
builder.Services.AddScoped<IOrdemServicoRepository, IndicadoresOrdemServicoRepository>();
builder.Services.AddScoped<IOrdemServicoRankingRepository, OrdemServicoRankingRepository>();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IIndicadoresService, IndicadoresService>();
builder.Services.AddScoped<IDadosTecnicosService, DadosTecnicosService>();
builder.Services.AddScoped<IDadosConsumoService, DadosConsumoService>();
builder.Services.AddScoped<IDadosLigacoesService, DadosLigacoesService>();
builder.Services.AddScoped<IOrdemServicosService, OrdemServicosService>();
builder.Services.AddScoped<IOrdemServicoRankingService, OrdemServicoRankingService>();

builder.Services.AddSingleton<IIndicadoresWorkerService, IndicadoresWorkerService>();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
