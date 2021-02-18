using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class D_Maleta: DataAccess
    {

        private string _conn;

        public D_Maleta(string connectionString) : base(connectionString)
        {
            _conn = connectionString;
        }

        public List<AgenciaVObjetos.Maleta> Consultar(string spName)
        {
            var dataT = ConsultarProcedimiento(spName);
            List<AgenciaVObjetos.Maleta> resultado = new List<AgenciaVObjetos.Maleta>();

            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                resultado.Add(new AgenciaVObjetos.Maleta()
                {
                    MaletaID = Convert.ToInt32(dataT.Rows[i]["MaletaID"]),
                    PasajeroID = Convert.ToInt32(dataT.Rows[i]["PasajeroID"]),
                    MaletaAlto = Convert.ToDecimal(dataT.Rows[i]["MaletaAlto"]),
                    MaletaLargo = Convert.ToDecimal(dataT.Rows[i]["MaletaLargo"]),
                    MaletaAncho =Convert.ToDecimal(dataT.Rows[i]["MaletaAncho"]),
                    MaletaPeso = Convert.ToDecimal(dataT.Rows[i]["MaletaPeso"])


                });
            }

            return resultado;
        }


        public bool insertar(string spName, AgenciaVObjetos.Maleta item)
        {
            try
            {
                var conn = new SqlConnection(_conn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaletaAlto", item.MaletaAlto);
                cmd.Parameters.AddWithValue("@MaletaLargo", item.MaletaLargo);
                cmd.Parameters.AddWithValue("@MaletaAncho", item.MaletaAncho);
                cmd.Parameters.AddWithValue("@MaletaPeso", item.MaletaPeso);
                cmd.Parameters.AddWithValue("@PasajeroID", item.PasajeroID);
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
