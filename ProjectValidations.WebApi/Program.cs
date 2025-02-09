
using FluentValidation;
using FluentValidation.AspNetCore;
using ProjectValidations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddValidatorsFromAssembly(typeof(PeticionBaseValidation).Assembly);
builder.Services.AddValidatorsFromAssembly(typeof(RedebanValidator).Assembly);
builder.Services.AddValidatorsFromAssembly(typeof(MedianetValidator).Assembly);

// Habilitar la validación automática de FluentValidation
builder.Services.AddFluentValidationAutoValidation();

// registrar interfaces
builder.Services.AddScoped<IOrquestadorService, OrquestadorService>();
builder.Services.AddScoped<IPeticion, PeticionBase>();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

