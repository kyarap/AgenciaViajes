using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AgenciaDAL
{
    public class DataAccess
    {
        private SqlConnection conn;
        public DataAccess(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public DataTable ConsultarProcedimiento(string spName)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;

            }
            
        }

        
    }
}


