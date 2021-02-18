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
    public partial class FrmParametricas : Form
    {
        public FrmParametricas()
        {
            InitializeComponent();
        }
           

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            FrmPais frm  = new FrmPais();
            frm.Show();
        }

        private void btnTipoServicio_Click(object sender, EventArgs e)
        {
            FrmTipoServicio FormTipoServ = new FrmTipoServicio();
            FormTipoServ.Show();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            FrmCiudad FormCiudad = new FrmCiudad();
            FormCiudad.Show();
        }
    }
}
