using Db;
using Domain.User;
using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Repos;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<ExampleDbContext>();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies([Assembly.GetExecutingAssembly()]);
});

builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation();
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
