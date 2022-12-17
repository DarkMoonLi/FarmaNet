using FarmaNetBackend;
using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IMedicationRepository, MedicationRepository>();
builder.Services.AddScoped<IUnitOfWork>(sp => sp.GetService<MedicationDbContext>());

var configBuilder = new ConfigurationBuilder();
configBuilder.SetBasePath(Directory.GetCurrentDirectory());
configBuilder.AddJsonFile("appsettings.json");

var config = configBuilder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<MedicationDbContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

var app = builder.Build();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();