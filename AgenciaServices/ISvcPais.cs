using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgenciaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISvcPais" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISvcPais
    {
        [OperationContract]
        List<AgenciaVObjetos.Pais> Consultar();

        [OperationContract]
        bool Insertar(AgenciaVObjetos.Pais pais);
    }
}
