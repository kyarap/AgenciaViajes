using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_ServicioAdicional
    {
        private AgenciaDAL.D_ServicioAdicional _ServicioAdicional;
        public N_ServicioAdicional(string conn)
        {
            _ServicioAdicional = new AgenciaDAL.D_ServicioAdicional(conn);
        }

        public List<AgenciaVObjetos.ServicioAdicional> ConsultarServicioAdicionales()
        {
            return _ServicioAdicional.Consultar("SP_ServicioAdicional_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.ServicioAdicional ServicioAdicional)
        {
            return _ServicioAdicional.insertar("SP_ServicioAdicional_INSERTAR", ServicioAdicional);
        }

    }
}
