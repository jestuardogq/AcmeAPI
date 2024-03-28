using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AcmeAPI.Models
{
    public class Encuesta
    {
        [Key]
        public int id_encuesta {  get; set; }
        public string nombre_encuesta { get; set; }
        public string descripcion_encuesta { get; set; }
        public string creacion { get; set; }

        public int UsuarioId {  get; set; }
        //public Usuario Usuario { get; set; }
    }
}
