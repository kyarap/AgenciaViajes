using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_TipoDocumento
    {
        private AgenciaDAL.D_TipoDocumento _TipoDocumento;
        public N_TipoDocumento(string conn)
        {
            _TipoDocumento = new AgenciaDAL.D_TipoDocumento(conn);
        }

        public List<AgenciaVObjetos.TipoDocumento> ConsultarTipoDocumentoes()
        {
            return _TipoDocumento.Consultar("SP_TIPODOCUMENTO_CONSULTAR");
        }

    }
}
