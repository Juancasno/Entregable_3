using CRUDMinimalAPI.Handlers;
using static CRUDMinimalAPI.Handlers.AutorHandler;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var autorHandler = new AutorHandler();
var libroHandler = new LibroHandler();

List<LibroDTO> BD = new List<LibroDTO>();
LibroHandler handler = new LibroHandler(BD);

// Rutas de Autor
app.MapGet("/api/v1/autor/{id:guid}", (Guid id) => autorHandler.ObtenerAutor(id));
app.MapPost("/api/v1/autor", (AutorDTO autor) => { autorHandler.CrearAutor(autor); return "Autor creado"; });
app.MapPut("/api/v1/autor/{id:guid}", (Guid id, AutorDTO autor) => { autorHandler.ActualizarAutor(id, autor); return "Autor actualizado"; });
app.MapDelete("/api/v1/autor/{id:guid}", (Guid id) => { autorHandler.EliminarAutor(id); return "Autor eliminado"; });

// Rutas de Libro
app.MapGet("/api/v1/libro/{id:guid}", (Guid id) => libroHandler.ObtenerLibro(id));
app.MapPost("/api/v1/libro", (LibroDTO libro) => { libroHandler.CrearLibro(libro); return "Libro creado"; });
app.MapPut("/api/v1/libro/{id:guid}", (Guid id, LibroDTO libro) => { libroHandler.ActualizarLibro(id, libro); return "Libro actualizado"; });
app.MapDelete("/api/v1/libro/{id:guid}", (Guid id) => { libroHandler.EliminarLibro(id); return "Libro eliminado"; });

app.Run();
