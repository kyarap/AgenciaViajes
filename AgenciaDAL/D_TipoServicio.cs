using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgenciaDAL
{
    public class D_TipoServicio : DataAccess
    {
        private string _conn;

        public D_TipoServicio(string connectionString) : base(connectionString) 
        {
            _conn = connectionString;        
        }



        public List<AgenciaVObjetos.TipoServicio> ConsultarTipoServicios(string spname)
        {
            var dataT = ConsultarProcedimiento(spname);
            List<AgenciaVObjetos.TipoServicio> resultado = new List<AgenciaVObjetos.TipoServicio>();


            for (int i=0; i<dataT.Rows.Count; i++)
            {

                resultado.Add(new AgenciaVObjetos.TipoServicio() {
                    TipoServicioID = Convert.ToInt32(dataT.Rows[i]["TipoServicioID"]),
                    TipoServicioNombre = Convert.ToString(dataT.Rows[i]["TipoServicioNombre"]),
                    TipoServicioFecha = Convert.ToDateTime(dataT.Rows[i]["TipoServicioFecha"])
                });
                               
            }
            return resultado;
        }
    }
}
