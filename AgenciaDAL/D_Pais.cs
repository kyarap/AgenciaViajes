using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class D_Pais : DataAccess
    {
        private string _conn;
        public D_Pais(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.Pais> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.Pais> resultado = new List<AgenciaVObjetos.Pais>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.Pais()
                {
                    PaisID = Convert.ToInt32(dataT.Rows[i]["PaisID"]),
                    PaisNombre = dataT.Rows[i]["PaisNombre"].ToString(),
                    PaisFecha = Convert.ToDateTime(dataT.Rows[i]["PaisFecha"])
                });
            }

            return resultado;
        }


        public bool insertar(string spName, AgenciaVObjetos.Pais item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaisNombre", item.PaisNombre);
                cmd.Parameters.AddWithValue("@PaisFecha", item.PaisFecha);
                

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
