using System.ComponentModel.DataAnnotations;

namespace registrotecnicos.Models
{
    public class Tecnicos
    {
        [Key]
        public int TecnicoId { get; set; }
       

        

        public string? TecnicosTipos { get; set; }

        public int tipoid { get; set; }
    }
}
