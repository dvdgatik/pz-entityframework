namespace projectef.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Creacion de modelos que se convertiran en tablas de la base de datos

//Clase Tareas y propiedades

// Guid Universally Unique Identifier
// Cada Tarea va a tener asignada una categoria 
public class Tarea {
    [Key]
    public Guid TareaId {get;set;}
    [ForeignKey("CategoriaId")]
    public Guid CategoriaId {get;set;}
    [Required]
    [MaxLength(200)]
    public string Titulo {get;set;}
    public string Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public DateTime FechaCreacion {get; set;}
    public virtual Categoria Categoria {get; set;}

    [NotMapped] //Omite esta propiedad a la base de datos
    public string Resumen {get;set;}
}


//Enumeracion en base de datos
public enum Prioridad {
    Baja,
    Media,
    Alta
}