namespace projectef.Models;
using Microsoft.EntityFrameworkCore;

//EL modelo se llama de manera singular y las colecciones en plurarl, ya que representan toda la coleccion de datos (tabla) de ese modelo
public class TareasContext: DbContext 
{
    //Esto representara una tabla dentro del contexto de Entity Framework
    public DbSet<Categoria> Categorias  {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    //Metodo base del constructor
    //Tipo tareas context
    // nombrado como options
    // metodo base que ya existe dentro de la classe DbContext, le pasamos los options que estemos recibiendo
    public TareasContext(DbContextOptions<TareasContext> options) :base(options) {}
}

//Configuracion de Entity Framework


