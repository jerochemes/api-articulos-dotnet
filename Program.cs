using AutoMapper;
using TP2BACKEND_DEFINITIVO.mapper;
using TP2BACKEND_DEFINITIVO.repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar AutoMapper
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Repositorio
builder.Services.AddScoped<IArticuloRepository, ArticuloRepository>();

// Controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger (para probar la API fácilmente)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();