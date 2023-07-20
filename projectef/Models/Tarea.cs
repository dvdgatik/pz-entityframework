namespace projectef.Models;

//Creacion de modelos que se convertiran en tablas de la base de datos

//Clase Tareas y propiedades

// Guid Universally Unique Identifier
public class Tarea {
    public Guid TareaId {get;set;}
    public Guid CategoriaId {get;set;}
    public string Titulo {get;set;}
    public string Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public DateTime FechaCreacion {get; set;}
    public virtual Categoria Categoria {get; set;}
}


//Enumeracion en base de datos
public enum Prioridad {
    Baja,
    Media,
    Alta
}