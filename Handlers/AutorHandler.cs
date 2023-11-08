namespace CRUDMinimalAPI.Handlers
{
    public class AutorHandler
    {
        private List<AutorDTO> autores = new List<AutorDTO>();

        public AutorDTO ObtenerAutor(Guid id)
        {
            return autores.FirstOrDefault(a => a.Id == id);
        }

        public void CrearAutor(AutorDTO autor)
        {
            autor.Id = Guid.NewGuid();
            autores.Add(autor);
        }

        public void ActualizarAutor(Guid id, AutorDTO autor)
        {
            var autorExistente = autores.FirstOrDefault(a => a.Id == id);
            if (autorExistente != null)
            {
                autorExistente.Nombre = autor.Nombre;
                autorExistente.Nacionalidad = autor.Nacionalidad;
            }
        }

        public void EliminarAutor(Guid id)
        {
            autores.RemoveAll(a => a.Id == id);
        }

        public class AutorDTO
{
    public Guid Id { get; set; } 
    public string Nombre { get; set; }
    public string Nacionalidad { get; set; }
}
    }
}
