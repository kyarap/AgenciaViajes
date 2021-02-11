using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_Ciudad
    {
        private AgenciaDAL.D_Ciudad _Ciudad;
        public N_Ciudad(string conn)
        {
            _Ciudad = new AgenciaDAL.D_Ciudad(conn);
        }

        public List<AgenciaVObjetos.Ciudad> ConsultarCiudades()
        {
            return _Ciudad.Consultar("SP_CIUDAD_CONSULTAR");
        }

    }
}
