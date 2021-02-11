using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcPais" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcPais.svc o SvcPais.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcPais : ISvcPais
    {
        AgenciaNegocios.N_Pais _pais;
        public SvcPais()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _pais = new AgenciaNegocios.N_Pais(connString);
        }

        public List<AgenciaVObjetos.Pais> Consultar()
        {
            var data = _pais.ConsultarPaises();
            return data;

        }



        public bool Insertar(AgenciaVObjetos.Pais pais)
        {
            var data = _pais.Guardar(pais);
            return data;

        }
    }
}
