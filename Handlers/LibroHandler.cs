namespace CRUDAnimalAPI.Handlers
{
    public class LibroHandler
    {
        private List<LibroDTO> libros;

        public LibroHandler(List<LibroDTO> baseDeDatos)
        {
            libros = baseDeDatos;
        }

        public LibroHandler()
        {
        }

        public LibroDTO ObtenerLibro(Guid id)
        {
            return libros.FirstOrDefault(l => l.Id == id);
        }

        public void CrearLibro(LibroDTO libro)
        {
            libro.Id = Guid.NewGuid();
            libros.Add(libro);
        }

        public void ActualizarLibro(Guid id, LibroDTO libro)
        {
            var libroExistente = libros.FirstOrDefault(l => l.Id == id);
            if (libroExistente != null)
            {
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Resumen = libro.Resumen;
                libroExistente.AutorId = libro.AutorId;
            }
        }

        public void EliminarLibro(Guid id)
        {
            libros.RemoveAll(l => l.Id == id);
        }
    }

    public class LibroDTO
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Resumen { get; set; }
    public Guid AutorId { get; set; }
}
}
