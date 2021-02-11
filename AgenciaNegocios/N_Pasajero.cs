using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_Pasajero
    {

        private AgenciaDAL.D_Pasajero _Pasajero;
        public N_Pasajero(string conn)
        {
            _Pasajero = new AgenciaDAL.D_Pasajero(conn);
        }

        public List<AgenciaVObjetos.Pasajero> ConsultarPasajeroes()
        {
            return _Pasajero.Consultar("SP_PASAJERO_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.Pasajero pasajero)
        {
            return _Pasajero.insertar("SP_PASAJERO_INSERTAR", pasajero);
        }

      

    }
}
