using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using PruebaNET_JulianForero.Data;
using PruebaNET_JulianForero.Repositories;
using PruebaNET_JulianForero.Services;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var databaseName = Environment.GetEnvironmentVariable("DB_NAME");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var username = Environment.GetEnvironmentVariable("DB_USERNAME");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={databaseName};uid={username};password={password}";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddScoped<IRoomsRepository, RoomServices>();
builder.Services.AddScoped<IGuestRepository, GuestServices>();
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeServices>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeServices>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
