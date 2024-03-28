using System.ComponentModel.DataAnnotations;

namespace AcmeAPI.Models
{
    public class Campo
    {
        [Key]
        public int Id_campo { get; set; }

        public bool obligatorio { get; set; }
        public string nombre_campo { get; set; }
        public string titulo_campo { get; set; }
        public string tipo_campo { get; set; }
        public Encuesta encuesta { get; set; }

    }
}
