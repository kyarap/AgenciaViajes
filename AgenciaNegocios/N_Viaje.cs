using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_Viaje
    {

        private AgenciaDAL.D_Viaje _Viaje;
        public N_Viaje(string conn)
        {
            _Viaje = new AgenciaDAL.D_Viaje(conn);
        }

        public List<AgenciaVObjetos.Viaje> ConsultarViajees()
        {
            return _Viaje.Consultar("SP_Viaje_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.Viaje Viaje)
        {
            return _Viaje.insertar("SP_Viaje_INSERTAR", Viaje);
        }


    }
}
