using System.Reflection;
using API.Extensions;
using AspNetCoreRateLimit;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureRateLimiting();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();
builder.Services.AddApplicationServices();


builder.Services.AddDbContext<TiendaContext>(optionsBuilder =>
{
    string connectionString = builder.Configuration.GetConnectionString("MySqlConex");
    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseIpRateLimiting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
