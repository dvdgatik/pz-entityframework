using Microsoft.EntityFrameworkCore;
using projectef.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
//Hacemos el mapeo del mismo contexto
builder.Services.AddSqlServer<TareasContext>("Data Source=(local);Initial Catalog=TareasDb;Trust Server Certificate=true;user id=sa;password=12358");
var app = builder.Build();

// Rutas
app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) => 
{
    dbContext.Database.EnsureCreated();
    return  Results.Ok("Base de datos en Memoria: " + dbContext.Database.IsInMemory());
});

app.Run();

// dotnet build
// dotnet run
