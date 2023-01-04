using cGisDashBoard.Helpers.Auth;
using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Repositories;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services;
using cGisDashBoard.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    builder => builder.EnableRetryOnFailure()));


builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
builder.Services.AddScoped<IIndicadoresRepository, IndicadoresRepository>();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IIndicadoresService, IndicadoresService>();

var app = builder.Build();

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
