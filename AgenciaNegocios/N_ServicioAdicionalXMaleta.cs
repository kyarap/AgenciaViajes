using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_ServicioAdicionalXMaleta
    {
        private AgenciaDAL.D_ServicioAdicionalXMaleta _ServicioAdicionalXMaleta;
        public N_ServicioAdicionalXMaleta(string conn)
        {
            _ServicioAdicionalXMaleta = new AgenciaDAL.D_ServicioAdicionalXMaleta(conn);
        }

        public List<AgenciaVObjetos.ServicioAdicionalXMaleta> ConsultarServicioAdicionalXMaletaes()
        {
            return _ServicioAdicionalXMaleta.Consultar("SP_SERVADICIONALXMALETA_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.ServicioAdicionalXMaleta ServicioAdicionalXMaleta)
        {
            return _ServicioAdicionalXMaleta.insertar("SPSERVADICIONALXMALETA_INSERTAR", ServicioAdicionalXMaleta);
        }

    }
}
