using Microsoft.EntityFrameworkCore;
using SafeRoute.API.Data;
using SafeRoute.API.Repositories;
using SafeRoute.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=SafeRoute.db"));

builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddHostedService<DeliverySimulationService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
