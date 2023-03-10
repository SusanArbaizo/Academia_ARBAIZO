namespace Academia.Entidades
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public string NombreCompleto
        {
            get { return Codigo + " - " + Apellidos + " " + Nombres; }
        }

    }
}
