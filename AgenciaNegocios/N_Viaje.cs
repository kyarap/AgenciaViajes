using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaNegocios
{
    public class N_Viaje
    {

        private AgenciaDAL.D_Viaje _Viaje;
        private AgenciaDAL.D_Pasajero _pasajero;
        private AgenciaDAL.D_Maleta _maleta;
        public N_Viaje(string conn)
        {
            _Viaje = new AgenciaDAL.D_Viaje(conn);
            _pasajero = new AgenciaDAL.D_Pasajero(conn);
            _maleta = new AgenciaDAL.D_Maleta(conn);
        }

        public List<AgenciaVObjetos.Viaje> ConsultarViajees()
        {
            return _Viaje.Consultar("SP_Viaje_CONSULTAR");
        }

        public bool Guardar(AgenciaVObjetos.Viaje Viaje)
        {
            Viaje.PasajeroID = _pasajero.insertar("SP_pasajero_INSERTAR", Viaje.Pasajero);
            _Viaje.insertar("SP_Viaje_INSERTAR", Viaje);

            if (Viaje.Pasajero.Maletas != null)
            {

                foreach (var maleta in Viaje.Pasajero.Maletas)
                {
                    maleta.PasajeroID = Viaje.PasajeroID;
                    return _maleta.insertar("SP_maleta_INSERTAR", maleta);
                }
            }
            return true;
            
        }


    }
}
