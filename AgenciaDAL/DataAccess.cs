﻿using System;
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
                throw new Exception("Error de conexion", ex);

            }
            
        }

        public DataTable ConsultarProcedimiento(string spName, Dictionary<string,dynamic> parameters)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                }

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion", ex);

            }

        }


    }
}


