using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class D_Ciudad: DataAccess
    {
        private string _conn;
        public D_Ciudad(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.Ciudad> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.Ciudad> resultado = new List<AgenciaVObjetos.Ciudad>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.Ciudad()
                {
                    CiudadID = Convert.ToInt32(dataT.Rows[i]["CiudadID"]),
                    CiudadNombre = dataT.Rows[i]["CiudadNombre"].ToString(),
                    PaisID = Convert.ToInt32(dataT.Rows[i]["PaisID"]),
                    PaisNombre = dataT.Rows[i]["PaisNombre"].ToString(),
                    CiudadFecha = Convert.ToDateTime(dataT.Rows[i]["CiudadFecha"])
                });
            }

            return resultado;
        }

    }
}
