using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaVObjetos
{
    public class Viaje
    {
        public int ViajeID { get; set; }
        public int PasajeroID { get; set; }

        public string PasajeroNombre { get; set; }
       


        public string PasajeroApellido { get; set; }
      
        public int PaisOrigenID { get; set; }
        public int CiudadOrigenID { get; set; }
        public int PaisDestinoID { get; set; }
        public int CiudadDestinoID { get; set; }
        
        public int ServicioAdicionalID { get; set; }
        public DateTime ViajeDeFecha { get; set; }

        public bool Estado { get; set;  }

         public int TipoServicioID { get; set; }

        public double NumeroDeMaletas { get; set; }

        public Pasajero Pasajero { get; set; }





    }
}
