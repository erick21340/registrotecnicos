using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registrotecnicos.Models
{
    public class Incentivos
    {
        [Key]
        public int  IncentivoId { get; set; }


        public DateTime Fecha { get; set; }

        [ForeignKey("TecnicoId")]
        public int TecnicoId {  get; set; }

        public string Descripcion { get; set; }

        public int CantidadServicios { get; set; }


        public decimal? Monto { get; set; }
    }
}
