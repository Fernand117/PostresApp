namespace Postres.Dominio.Entidades
{
    public class DatosUsuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Paterno { get; set; } = string.Empty;
        public string Materno { get; set; } = string.Empty;
        public string FotoPerfil { get; set; } = string.Empty;
        public string FotoPortada { get; set; } = string.Empty;
        public Guid IdUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
