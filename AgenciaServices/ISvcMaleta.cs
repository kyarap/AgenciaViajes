using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISvcMaleta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISvcMaleta
    {
        [OperationContract]
        List<AgenciaVObjetos.Maleta> Consultar();

        [OperationContract]
        bool Insertar(AgenciaVObjetos.Maleta Maleta);
    }
}
