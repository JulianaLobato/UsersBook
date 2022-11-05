using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UsersBook.Application.AppServices;
using UsersBook.Application.Interfaces;
using UsersBook.Domain.Handlers;
using UsersBook.Domain.Interfaces.Repositories;
using UsersBook.Domain.Interfaces.Services;
using UsersBook.Domain.Services;
using UsersBook.Infrastructure.Context;
using UsersBook.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ServerConection")));

var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMappingWebApi()); });
builder.Services.AddSingleton(mapperConfig.CreateMapper());

builder.Services.AddScoped<IUserAppService, UserAppService>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddEnvironmentVariables();



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


