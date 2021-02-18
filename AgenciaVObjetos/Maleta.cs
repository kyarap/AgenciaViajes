using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaVObjetos
{
    public class Maleta
    {


        public int MaletaID { get; set; }
        public decimal MaletaAlto { get; set; }
        public decimal MaletaLargo { get; set; }
        public decimal MaletaAncho { get; set; }
        public decimal MaletaPeso { get; set; }
        public int PasajeroID { get; set; }

        public List<ServicioAdicional> ServiciosAdicionales { get; set; }
    }
}
