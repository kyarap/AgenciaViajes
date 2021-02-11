using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcViaje" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcViaje.svc o SvcViaje.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcViaje : ISvcViaje
    {
        AgenciaNegocios.N_Viaje _Viaje;
        public SvcViaje()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _Viaje = new AgenciaNegocios.N_Viaje(connString);
        }

        public List<AgenciaVObjetos.Viaje> Consultar()
        {
            var data = _Viaje.ConsultarViajees();
            return data;

        }

        public bool Insertar(AgenciaVObjetos.Viaje Viaje)
        {
            var data = _Viaje.Guardar(Viaje);
            return data;

        }
    }
}
