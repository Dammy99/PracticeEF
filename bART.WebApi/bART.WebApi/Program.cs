using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Extentions;
using bART.Data.MappingProfiles;
using bART.Data.Services.Implementation;
using bART.Data.Validations;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidation(config => config
    .RegisterValidatorsFromAssemblyContaining<IncidentValidator>());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDomainDataServices();
builder.Services.AddDI();
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfiles(new List<Profile> { new IncidentProfile() });
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
//builder.Services.AddDbContext<BartContext>
//    (x => x.UseSqlServer(builder.Configuration.GetConnectionString("BartConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
