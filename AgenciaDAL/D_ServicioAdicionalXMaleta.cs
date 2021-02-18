using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgenciaDAL
{
    public class D_ServicioAdicionalXMaleta : DataAccess
    {
        private string _conn;

        public D_ServicioAdicionalXMaleta(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.ServicioAdicionalXMaleta> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.ServicioAdicionalXMaleta> resultado = new List<AgenciaVObjetos.ServicioAdicionalXMaleta>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.ServicioAdicionalXMaleta()
                {
                    ServicioAdicionalXMaletaID = Convert.ToInt32(dataT.Rows[i]["ServicioAdicionalXMaletaID"]),
                    ServicioAdicionalID = Convert.ToInt32( dataT.Rows[i]["ServicioAdicionalID"]),
                    MaletaID = Convert.ToInt32(dataT.Rows[i]["MaletaID"]),
                    ServicioAdicionalXMaletaFecha = Convert.ToDateTime(dataT.Rows[i]["ServicioAdicionalXMaletaFecha"]).ToString()
                });
            }

            return resultado;
        }


        public bool insertar(string spName, AgenciaVObjetos.ServicioAdicionalXMaleta item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServicioAdicionalID", item.ServicioAdicionalID);
                cmd.Parameters.AddWithValue("@MaletaID", item.MaletaID);
                cmd.Parameters.AddWithValue("ServicioAdicionalXMaletaFecha", item.ServicioAdicionalXMaletaFecha);

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
