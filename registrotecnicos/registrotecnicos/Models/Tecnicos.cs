using System.ComponentModel.DataAnnotations;

namespace registrotecnicos.Models
{
    public class Tecnicos
    {
        [Key]

        public int TiposId { get; set; }

        public string? TecnicosTipos { get; set; }

    }
}
