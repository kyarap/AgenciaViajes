using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class D_Pasajero: DataAccess
    {

        private string _conn;
        public D_Pasajero(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.Pasajero> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.Pasajero> resultado = new List<AgenciaVObjetos.Pasajero>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.Pasajero()
                {
                    PasajeroID = Convert.ToInt32(dataT.Rows[i]["PasajeroID"]),
                    PasajeroNombre = dataT.Rows[i]["PasajeroNombre"].ToString(),
                    // 
                    PasajeroApellido = dataT.Rows[i]["PasajeroApellido"].ToString(),
                    TipoDocumentoID =Convert.ToInt32( dataT.Rows[i]["TipoDocumentoID"]),
                    NumDocumento = dataT.Rows[i]["NumDocumento"].ToString(),
                    PasajeroTel = dataT.Rows[i]["PasajeroTel"].ToString(),
                    PasajeroCorreo = dataT.Rows[i]["PasajeroCorreo"].ToString(),
                    PasajeroFecha = Convert.ToDateTime(dataT.Rows[i]["PasajeroFecha"])

                });
            }

            return resultado;
        }

        public bool insertar(string spName, AgenciaVObjetos.Pasajero item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PasajeroNombre", item.PasajeroNombre);
                cmd.Parameters.AddWithValue("@PasajeroApellido", item.PasajeroApellido);
                cmd.Parameters.AddWithValue("@PasajeroFecha", item.PasajeroFecha);
                cmd.Parameters.AddWithValue("@PasajeroCorreo", item.PasajeroCorreo);
                cmd.Parameters.AddWithValue("@PasajeroTel", item.PasajeroTel);
                cmd.Parameters.AddWithValue("@TipoDocumentoID", item.TipoDocumentoID);
                cmd.Parameters.AddWithValue("@NumDocumento", item.NumDocumento);

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
