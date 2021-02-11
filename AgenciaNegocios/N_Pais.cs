using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
          public class N_Pais
        {
            private AgenciaDAL.D_Pais _pais;
            public N_Pais(string conn)
            {
                _pais = new AgenciaDAL.D_Pais(conn);
            }

            public List<AgenciaVObjetos.Pais> ConsultarPaises()
            {
                return _pais.Consultar("SP_PAIS_CONSULTAR");
            }

        public bool Guardar(AgenciaVObjetos.Pais pais)
        {
            return _pais.insertar("SP_PAIS_INSERTAR", pais);
        }

    }
    
}
