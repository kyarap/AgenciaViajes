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

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            FrmPais FormularioPais = new FrmPais();
            FormularioPais.Show();
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            FrmDatosViaje FormularioViaje = new FrmDatosViaje();
            FormularioViaje.Show();
        }
    }
}
