using System.ComponentModel.DataAnnotations;

namespace AcmeAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id_usuario {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
    }
}
