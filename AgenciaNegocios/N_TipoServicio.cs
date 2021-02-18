using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_TipoServicio
    {
        private AgenciaDAL.D_TipoServicio _tipoServ;

        public N_TipoServicio(string conn)
        {
            _tipoServ = new AgenciaDAL.D_TipoServicio(conn);
        }

        public List<AgenciaVObjetos.TipoServicio> ConsultarTipoServicios()
        {
            return _tipoServ.ConsultarTipoServicios("SP_TIPO_SERVICIO_CONSULTAR");
        }



    }
}
