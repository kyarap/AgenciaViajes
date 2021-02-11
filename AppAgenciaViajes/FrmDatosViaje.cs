using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AppAgenciaViajes
{
    public partial class FrmDatosViaje : Form
    {

        private int idPasj = 0;
        public FrmDatosViaje()
        {
            InitializeComponent();
        }

        public void CargarTipoDocumento()
        {
            try
            {

                TipoDocumentoServiceReference.SvcTipoDocumentoClient client = new TipoDocumentoServiceReference.SvcTipoDocumentoClient();
                var data = client.Consultar();
                cboTipoDocumento.DataSource = data;
                cboTipoDocumento.ValueMember = "TipoDocumentoID";
                cboTipoDocumento.DisplayMember = "TipoDocumentoNombre";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPasajeroAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (CargarObjetoPasajero())
                {
                    tpViaje.TabPages.Clear();
                    tpViaje.TabPages.Add(tpDatosViaje);
                    MessageBox.Show("Se guardo con Exito los datos del pasajero");
                }               

            }
            catch (Exception)
            {

                throw;
            } 
        }


        public bool CargarObjetoPasajero()
        {           

            try
            {
               
                PasajeroServiceReference.SvcPasajeroClient ClientPasajero = new PasajeroServiceReference.SvcPasajeroClient();
                PasajeroServiceReference.Pasajero objPasajero = new PasajeroServiceReference.Pasajero();
                objPasajero.PasajeroNombre = txtPsjNombre.Text;
                objPasajero.PasajeroApellido = txtPsjApellido.Text;
                objPasajero.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                objPasajero.NumDocumento = txtNumDocumento.Text;
                objPasajero.PasajeroTel = txtTelefono.Text;
                objPasajero.PasajeroCorreo = txtPsjCorreo.Text;
                objPasajero.PasajeroFecha = DateTime.Now;
                var data = ClientPasajero.Insertar(objPasajero);

                idPasj = objPasajero.PasajeroID; 

                return true;

            }
            catch (Exception ex)
            {
                return false;
                
            }
            

           
        }


        private void txtNumDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                
                e.Handled = true;
            }
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void FrmDatosViaje_Load(object sender, EventArgs e)
        {
            tpViaje.TabPages.Clear();
            tpViaje.TabPages.Add(tpDatosPasajero);

            CargarTipoDocumento();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tpDatosPasajero_Click(object sender, EventArgs e)
        {

        }

        private void btnViajeAceptar_Click(object sender, EventArgs e)
        {
            ValidarCantMaletas();          

        }



        #region Datos_Viaje

        public void CargarPaisOrigen()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                var data = ClientPais.Consultar();
                cbPaisOrigen.DataSource = data;
                cbPaisOrigen.ValueMember = "PaisOrigenID";
                cbPaisOrigen.DisplayMember = "PaisNombre";               

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CargarCiudadOrigen(int PaisID)
        {
            try
            {
                CiudadServiceReference.SvcCiudadClient clientCiudad = new CiudadServiceReference.SvcCiudadClient();
                var data = clientCiudad.Consultar();
                data = data.Where(s=> s.PaisID==PaisID).ToList();
                cbCiudadOrigen.DataSource = data;
                cbCiudadOrigen.ValueMember = "CiudadID";
                cbCiudadOrigen.DisplayMember = "CiudadNombre";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarPaisDestino()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                var data = ClientPais.Consultar();
                cbPaisOrigen.DataSource = data;
                cbPaisOrigen.ValueMember = "PaisID";
                cbPaisOrigen.DisplayMember = "PaisNombre";

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CargarCiudadDestino(int PaisID)
        {
            try
            {
                CiudadServiceReference.SvcCiudadClient clientCiudad = new CiudadServiceReference.SvcCiudadClient();
                var data = clientCiudad.Consultar();
                data = data.Where(s => s.PaisID == PaisID).ToList();
                cbCiudadDestino.DataSource = data;
                cbCiudadDestino.ValueMember = "CiudadID";
                cbCiudadDestino.DisplayMember = "CiudadNombre";
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void ValidarCantMaletas()
        {
            /*Despues de guardar*/
            if (nudMaletas.Value > 0)
            {
                tpViaje.TabPages.Clear();
                tpViaje.TabPages.Add(tpMaleta);

            }
            else
            {
                tpViaje.TabPages.Clear();
                tpViaje.TabPages.Add(tpResumen);
            }
        }


        public bool CargarObjViaje()
        {
            try
            {
                PasajeroServiceReference.SvcPasajeroClient ClientPasajero = new PasajeroServiceReference.SvcPasajeroClient();
                PasajeroServiceReference.Pasajero objPasajero = new PasajeroServiceReference.Pasajero();
                objPasajero.PasajeroNombre = txtPsjNombre.Text;
                objPasajero.PasajeroApellido = txtPsjApellido.Text;
                objPasajero.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                objPasajero.NumDocumento = txtNumDocumento.Text;
                objPasajero.PasajeroTel = txtTelefono.Text;
                objPasajero.PasajeroCorreo = txtPsjCorreo.Text;
                objPasajero.PasajeroFecha = DateTime.Now;
                var data = ClientPasajero.Insertar(objPasajero);

                idPasj = objPasajero.PasajeroID;

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }






        #endregion

        
    }
}
