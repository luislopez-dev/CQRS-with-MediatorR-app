using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(
    config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();