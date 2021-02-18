using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcMaleta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcMaleta.svc o SvcMaleta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcMaleta : ISvcMaleta
    {
        AgenciaNegocios.N_Maleta _Maleta;
        public SvcMaleta()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _Maleta = new AgenciaNegocios.N_Maleta(connString);
        }

        public List<AgenciaVObjetos.Maleta> Consultar()
        {
            var data = _Maleta.ConsultarMaletaes();
            return data;

        }



        public bool Insertar(AgenciaVObjetos.Maleta Maleta)
        {
            var data = _Maleta.Guardar(Maleta);
            return data;

        }
    }
}
