using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISvcServicioAdicionalXMaletaXMaleta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISvcServicioAdicionalXMaleta

    {
        [OperationContract]
        List<AgenciaVObjetos.ServicioAdicionalXMaleta> Consultar();

        [OperationContract]
        bool Insertar(AgenciaVObjetos.ServicioAdicionalXMaleta ServicioAdicionalXMaleta);
    }
}
