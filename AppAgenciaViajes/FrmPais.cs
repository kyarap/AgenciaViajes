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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            CargarGrillaPais();

        }

        public void CargarGrillaPais()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient client = new AgenciaServiceReference.SvcPaisClient();

                var data = client.Consultar();
                GrdPais.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPaisAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (CargarObjetoPais())
                {
                    CargarGrillaPais();
                    MessageBox.Show("Se guardo con Exito los datos del Pais");
                }

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
                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                AgenciaServiceReference.Pais objPais = new AgenciaServiceReference.Pais();

                objPais.PaisNombre = txtPais.Text;

                objPais.PaisFecha  = DateTime.Now;
                var data = ClientPais.Insertar(objPais);

                return true;

            }
            catch (Exception ex)
            {
                return false;

            }



        }
    }
}
