using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAgenciaViajes
{
    public partial class FrmCiudad : Form
    {
        public FrmCiudad()
        {
            InitializeComponent();
        }

        private void FrmCiudad_Load(object sender, EventArgs e)
        {

        }


        public void CargarPais()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                cbPais.SelectedIndex = -1;
                var data = ClientPais.Consultar();
                cbPais.DataSource = data;
                cbPais.ValueMember = "PaisID";
                cbPais.DisplayMember = "PaisNombre";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CargarObjetoPais()
        {

            try
            {
                //CiudadServiceReference.SvcCiudadClient CiudadClient = new CiudadServiceReference.SvcCiudadClient();
                //CiudadServiceReference.Ciudad objCiudad = new CiudadServiceReference.Ciudad();


                //objCiudad.PaisNombre = txtCiudad.Text;
                //objCiudad.CiudadFecha =DateTime.Now,

               
                //var data = CiudadClient.Insertar(objCiudad);

                return true;

            }
            catch (Exception ex)
            {
                return false;

            }



        }

    }
}
