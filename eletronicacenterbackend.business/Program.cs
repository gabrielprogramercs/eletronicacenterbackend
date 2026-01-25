using eletronicacenterbackend.business.Service;
using eletronicacenterbackend.business.Service.Interface;
using eletronicacenterbackend.data.Data;
using eletronicacenterbackend.data.Repository;
using eletronicacenterbackend.data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injeção de dependencia para Barras de led
builder.Services.AddScoped<IBarrasLedService, BarrasLedService>();
builder.Services.AddScoped<IBarrasLedRepository, BarrasLedRepository>();

//Injeção de dependencia para marca - Criar aqui

//Injeção de dependencia para placas tv - Criar aqui


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));



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
