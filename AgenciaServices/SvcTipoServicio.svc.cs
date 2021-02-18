using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcTipoServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcTipoServicio.svc o SvcTipoServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcTipoServicio : ISvcTipoServicio
    {
        AgenciaNegocios.N_TipoServicio _tipoServ; 

        public SvcTipoServicio()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _tipoServ = new AgenciaNegocios.N_TipoServicio(connectionString);
        }
        public List<AgenciaVObjetos.TipoServicio> Consultar()
        {
            var data = _tipoServ.ConsultarTipoServicios();
            return data;
        }
    }
}
