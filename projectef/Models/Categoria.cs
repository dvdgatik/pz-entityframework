namespace projectef.Models;

//Creacion de modelos que se convertiran en tablas de la base de datos

//Clase Categoria y propiedades
public class Categoria
{
    public Guid CategoriaId {get; set;}
    public string Nombre {get; set;}
    public string Decripcion {get; set;}

    // Propiedad virtual de tipo IColecction
    // traer todas la tareas relacionadas a esa categoria
    public virtual ICollection <Tarea> Tareas {get; set;}

}


//Cada modelo sera una tabla
// Cada atributos seran las columnas
