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
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }            

        private void btnMnuParametrica_Click(object sender, EventArgs e)
        {
            FrmParametricas FormParam = new FrmParametricas();
            FormParam.Show();
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            FrmDatosViaje formViaje = new FrmDatosViaje();
            formViaje.Show();
        }
    }
}
