using AutoMapper;
using bART.Data.Extentions;
using bART.Data.MappingProfiles;
using bART.Data.Validations;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidation(config => config
    .RegisterValidatorsFromAssemblyContaining<IncidentValidator>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDomainDataServices();
builder.Services.AddDI();
builder.Services.AddSwaggerGen();

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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
