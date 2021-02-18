using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_Maleta
    {
        private AgenciaDAL.D_Maleta _maleta;
        public N_Maleta(string conn)
        {
            _maleta = new AgenciaDAL.D_Maleta(conn);
        }

        public List<AgenciaVObjetos.Maleta> ConsultarMaletaes()
        {
            return _maleta.Consultar("SP_MALETA_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.Maleta Maleta)
        {
            return _maleta.insertar("SP_MALETA_INSERTAR", Maleta);
        }
    }
}
