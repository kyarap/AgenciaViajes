using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcServicioAdicional" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcServicioAdicional.svc o SvcServicioAdicional.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcServicioAdicional : ISvcServicioAdicional
    {
        AgenciaNegocios.N_ServicioAdicional _ServicioAdicional;
        public SvcServicioAdicional()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _ServicioAdicional = new AgenciaNegocios.N_ServicioAdicional(connString);
        }

        public List<AgenciaVObjetos.ServicioAdicional> Consultar()
        {
            var data = _ServicioAdicional.ConsultarServicioAdicionales();
            return data;

        }



        public bool Insertar(AgenciaVObjetos.ServicioAdicional ServicioAdicional)
        {
            var data = _ServicioAdicional.Guardar(ServicioAdicional);
            return data;

        }
    }
}
