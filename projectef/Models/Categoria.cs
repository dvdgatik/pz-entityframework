namespace projectef.Models;
using System.ComponentModel.DataAnnotations;

//Creacion de modelos que se convertiran en tablas de la base de datos

//Clase Categoria y propiedades

//Entity framework puede detectar cual es el PK ID a traves del nombre dle Id y nombre de la clase
public class Categoria
{
    [Key] // Estamos forzando a que utilice la propiedad como clave id
    public Guid CategoriaId {get; set;}
    [Required]
    [MaxLength(150)]
    public string Nombre {get; set;}
    public string Decripcion {get; set;}

    // Propiedad virtual de tipo IColecction
    // traer todas la tareas relacionadas a esa categoria
    public virtual ICollection <Tarea> Tareas {get; set;}

}


//Cada modelo sera una tabla
// Cada atributos seran las columnas
