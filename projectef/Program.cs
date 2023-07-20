
//Archivo de Clases
// Archivo de Projectos projectref
//appsettings archivos de propiedaddes de configuracion para la ejecucion
//
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Rutas
app.MapGet("/", () => "Hello World!");

app.Run();
