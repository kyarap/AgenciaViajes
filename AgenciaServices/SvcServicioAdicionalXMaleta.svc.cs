using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcServicioAdicionalXMaleta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcServicioAdicionalXMaleta.svc o SvcServicioAdicionalXMaleta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcServicioAdicionalXMaleta : ISvcServicioAdicionalXMaleta
    {
        AgenciaNegocios.N_ServicioAdicionalXMaleta _ServicioAdicionalXMaleta;
        public SvcServicioAdicionalXMaleta()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _ServicioAdicionalXMaleta = new AgenciaNegocios.N_ServicioAdicionalXMaleta(connString);
        }

        public List<AgenciaVObjetos.ServicioAdicionalXMaleta> Consultar()
        {
            var data = _ServicioAdicionalXMaleta.ConsultarServicioAdicionalXMaletaes();
            return data;

        }



        public bool Insertar(AgenciaVObjetos.ServicioAdicionalXMaleta ServicioAdicionalXMaleta)
        {
            var data = _ServicioAdicionalXMaleta.Guardar(ServicioAdicionalXMaleta);
            return data;

        }
    }
}
