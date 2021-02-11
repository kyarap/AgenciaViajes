using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaVObjetos
{
    public class Pasajero
    {


        public int PasajeroID { get; set; }
        [Required]

        [StringLength(100, ErrorMessage = "El número es demasiado largo")]
        public string PasajeroNombre { get; set; }
        [Required]


        [StringLength(100, ErrorMessage = "El número es demasiado largo")]
        public string PasajeroApellido { get; set; }
        [Required]


        public int TipoDocumentoID { get; set; }
        [Required]

        [StringLength(12, ErrorMessage = "El número es demasiado largo")]
        public string NumDocumento { get; set; }
        [Required]


        [StringLength(20, ErrorMessage = "El número es demasiado largo")]
        public string PasajeroTel { get; set; }
        [Required]

        [StringLength(50, ErrorMessage = "El número es demasiado largo")]
        public string PasajeroCorreo { get; set; }
        [Required]


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime PasajeroFecha { get; set; }
    }
}
