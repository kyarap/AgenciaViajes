using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcCiudad" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcCiudad.svc o SvcCiudad.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcCiudad : ISvcCiudad
    {
        AgenciaNegocios.N_Ciudad _Ciudad;
        public SvcCiudad()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _Ciudad = new AgenciaNegocios.N_Ciudad(connString);
        }

        public List<AgenciaVObjetos.Ciudad> Consultar()
        {
            var data = _Ciudad.ConsultarCiudades();
            return data;

        }



        public List<AgenciaVObjetos.Ciudad> ConsultarCiudadXPais(int idPais)
        {
            var data = _Ciudad.ConsultarXPais(idPais);
            return data;
        }
    }
}
