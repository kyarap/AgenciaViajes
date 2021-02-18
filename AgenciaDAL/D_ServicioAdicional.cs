using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AgenciaDAL
{
    public  class D_ServicioAdicional : DataAccess
    {
        private string _conn;

        public D_ServicioAdicional(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.ServicioAdicional> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.ServicioAdicional> resultado = new List<AgenciaVObjetos.ServicioAdicional>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.ServicioAdicional()
                {


                    ServicioAdicionalID = Convert.ToInt32(dataT.Rows[i]["ServicioAdicionalID"]),
                    ServicioAdicionalDescripcion = dataT.Rows[i]["ServicioAdicionalDescripcion"].ToString(),
                    ServicioAdicionalFecha = Convert.ToDateTime(dataT.Rows[i]["ServicioAdicionalFecha"])
                });
            }

            return resultado;
        }


        public bool insertar(string spName, AgenciaVObjetos.ServicioAdicional item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServicioAdicionalFecha", item.ServicioAdicionalFecha);
                cmd.Parameters.AddWithValue("@ServicioAdicionalDescripcion", item.ServicioAdicionalDescripcion);


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
