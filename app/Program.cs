using app.Behaviors;
using app.Data;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(
    config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddControllers();
builder.Services.AddSingleton<FakeDataStore>();
builder.Services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoginBehavior<,>));

var app = builder.Build();

app.MapControllers();

app.Run();