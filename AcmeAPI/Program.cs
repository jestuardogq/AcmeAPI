using AcmeAPI.Context;
using AcmeAPI.IService;
using AcmeAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Se agrega servicios de desarrollo
builder.Services.AddSingleton<IPruebaService, PruebaService>();
builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
builder.Services.AddSingleton<IEncuestaService, EncuestaService>();

//Se agrega configuracion para conextion de base de datos
var conexion = builder.Configuration.GetConnectionString("CadenaConexionSQLServer");
builder.Services.AddDbContext<ContextSqlServer>(options => options.UseSqlServer(conexion));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
