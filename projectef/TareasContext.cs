namespace projectef.Models;
using Microsoft.EntityFrameworkCore;

//EL modelo se llama de manera singular y las colecciones en plurarl, ya que representan toda la coleccion de datos (tabla) de ese modelo
public class TareasContext: DbContext 
{
    //Crea una coleccion y esto representara una tabla dentro del contexto de Entity Framework
    public DbSet<Categoria> Categorias  {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    //Metodo base del constructor
    //Tipo tareas context
    // nombrado como options
    // metodo base que ya existe dentro de la classe DbContext, le pasamos los options que estemos recibiendo
    public TareasContext(DbContextOptions<TareasContext> options) :base(options) {}
     
    //OnFluentAPI
     //Sobreescribimos el metodo al momento de hacer la creacion de la base de datos
     //parametro modelbuilder nos permite hacer la configuracion de nuestros modelos
    protected override void OnModelCreating(ModelBuilder modelBuider) 
    {
        //Quiero construir o diseñar las restricciones para el modelo de categoria
        modelBuider.Entity<Categoria>(categoria=>
        {
            //Las tablas deben estar en singular
            categoria.ToTable("Categoria");
            // Añadir clave primaria
            categoria.HasKey(p=> p.CategoriaId);
            categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p=> p.Decripcion);
        });
//Fluent API va a predominar sobre los Atributos data anotations
    }
}

//Contexto y Configuracion de Entity Framework


