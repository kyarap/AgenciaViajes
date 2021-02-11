using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaVObjetos
{
    public class Ciudad
    {

        public int CiudadID { get; set; }
        public string CiudadNombre { get; set; }
        public DateTime CiudadFecha { get; set; }
        public int PaisID { get; set; }
        public string PaisNombre { get; set; }
    }
}
