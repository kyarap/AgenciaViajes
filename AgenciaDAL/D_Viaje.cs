using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgenciaDAL
{
    public class D_Viaje: DataAccess
    {

        private string _conn;
        public D_Viaje(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.Viaje> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.Viaje> resultado = new List<AgenciaVObjetos.Viaje>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.Viaje()
                {
                    ViajeID = Convert.ToInt32(dataT.Rows[i]["ViajeID"]),
                    PasajeroID = Convert.ToInt32(dataT.Rows[i]["PasajeroID"]),
                    PasajeroNombre = dataT.Rows[i]["PasajeroNombre"].ToString(),
                    PasajeroApellido = dataT.Rows[i]["PasajeroApellido"].ToString(),
                                       



                    PaisOrigenID = Convert.ToInt32(dataT.Rows[i]["PaisOrigenID"]),
                    CiudadOrigenID = Convert.ToInt32(dataT.Rows[i]["CiudadOrigenID"]),
                    PaisDestinoID = Convert.ToInt32(dataT.Rows[i]["PaisDestinoID"]),
                    CiudadDestinoID = Convert.ToInt32(dataT.Rows[i]["CiudadDestinoID"]),
                    ServicioAdicionalID = Convert.ToInt32(dataT.Rows[i]["ServicioAdicionalID"]),
                    ViajeDeFecha = Convert.ToDateTime(dataT.Rows[i]["ViajeDeFecha"])
                });
            }

            return resultado;
        }


        public bool insertar(string spName, AgenciaVObjetos.Viaje item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PasajeroID", item.PasajeroID);
                cmd.Parameters.AddWithValue("@PaisOrigenID", item.PaisOrigenID);
                cmd.Parameters.AddWithValue("@ViajeDeFecha", item.ViajeDeFecha);
                cmd.Parameters.AddWithValue("@CiudadOrigenID", item.CiudadOrigenID);
                cmd.Parameters.AddWithValue("@PaisDestinoID", item.PaisDestinoID);
                cmd.Parameters.AddWithValue("@CiudadDestinoID", item.CiudadDestinoID);
                cmd.Parameters.AddWithValue("@ServicioAdicionalID", item.ServicioAdicionalID);

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
