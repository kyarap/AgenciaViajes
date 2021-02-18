using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcPasajero" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcPasajero.svc o SvcPasajero.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcPasajero : ISvcPasajero
    {
        AgenciaNegocios.N_Pasajero _Pasajero;
        public SvcPasajero()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _Pasajero = new AgenciaNegocios.N_Pasajero(connString);
        }

        public List<AgenciaVObjetos.Pasajero> Consultar()
        {
            var data = _Pasajero.ConsultarPasajeroes();
            return data;

        }

        public int Insertar(AgenciaVObjetos.Pasajero pasajero)
        {
            var data = _Pasajero.Guardar(pasajero);
            return data;

        }
    }
}
