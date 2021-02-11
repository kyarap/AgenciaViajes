using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class D_TipoDocumento: DataAccess
    {

        private string _conn;
        public D_TipoDocumento(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.TipoDocumento> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.TipoDocumento> resultado = new List<AgenciaVObjetos.TipoDocumento>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.TipoDocumento()
                {
                    TipoDocumentoID = Convert.ToInt32(dataT.Rows[i]["TipoDocumentoID"]),
                    TipoDocumentoNombre = dataT.Rows[i]["TipoDocumentoNombre"].ToString(),
                    TipoDocumentoFecha = Convert.ToDateTime(dataT.Rows[i]["TipoDocumentoFecha"])
                });
            }

            return resultado;
        }

    }
}
