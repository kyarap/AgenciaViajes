using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SvcTipoDocumento" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SvcTipoDocumento.svc o SvcTipoDocumento.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SvcTipoDocumento : ISvcTipoDocumento
    {
        AgenciaNegocios.N_TipoDocumento _TipoDocumento;
        public SvcTipoDocumento()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            _TipoDocumento = new AgenciaNegocios.N_TipoDocumento(connString);
        }

        public List<AgenciaVObjetos.TipoDocumento> Consultar()
        {
            var data = _TipoDocumento.ConsultarTipoDocumentoes();
            return data;

        }
    }
}
