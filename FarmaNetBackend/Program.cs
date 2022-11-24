using FarmaNetBackend;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IMedicationRepository, MedicationRepository>();

var app = builder.Build();

app.UseEndpoints(endpoints => endpoints.MapControllers());
    
app.Run();
