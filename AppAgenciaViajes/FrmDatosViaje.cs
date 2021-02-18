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

        private ViajeServiceReference.Pasajero objPasajero;
        private ViajeServiceReference.Viaje objViaje;
        private List<ViajeServiceReference.Maleta> objmaletas;
        private List<ViajeServiceReference.Maleta> objResMaleta;
       

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
                    //MessageBox.Show("Se guardo con Exito los datos del pasajero");

                    CargarPaisOrigen();
                    CargarPaisDestino();
                    CargarTipoServicio();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son válidos");
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
                objPasajero = new ViajeServiceReference.Pasajero();
                objPasajero.PasajeroNombre = txtPsjNombre.Text;
                objPasajero.PasajeroApellido = txtPsjApellido.Text;
                objPasajero.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                objPasajero.NumDocumento = txtNumDocumento.Text;
                objPasajero.PasajeroTel = txtTelefono.Text;
                objPasajero.PasajeroCorreo = txtPsjCorreo.Text;
                objPasajero.PasajeroFecha = DateTime.Now;
                

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

            objViaje = new ViajeServiceReference.Viaje();
            objViaje.NumeroDeMaletas = Convert.ToInt32( nudMaletas.Value);
            objViaje.CiudadOrigenID = Convert.ToInt32(cbCiudadOrigen.SelectedValue);
            objViaje.CiudadDestinoID= Convert.ToInt32(cbCiudadDestino.SelectedValue);
            objViaje.TipoServicioID = 1;
            objViaje.ViajeDeFecha = dateTimePicker1.Value;


            ValidarCantMaletas();          

        }



        #region Datos_Viaje

        public void CargarPaisOrigen()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                cbPaisOrigen.SelectedIndex = -1;
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



        public void CargarCiudadPaisOrigen(int idPais)
        {
            try
            {
                CiudadServiceReference.SvcCiudadClient client = new CiudadServiceReference.SvcCiudadClient();
                var data = client.ConsultarCiudadXPais(idPais);
                cbCiudadOrigen.DataSource = data;
                cbCiudadOrigen.ValueMember = "CiudadID";
                cbCiudadOrigen.DisplayMember = "CiudadNombre";
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void cbPaisOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ( cbPaisOrigen.Items.Count>0 && cbPaisOrigen.SelectedIndex >= 0)
                {
                    int id = 0;
                    if (cbPaisOrigen.SelectedValue.GetType() == typeof(AgenciaServiceReference.Pais))
                        id = ((AppAgenciaViajes.AgenciaServiceReference.Pais)cbPaisOrigen.SelectedValue).PaisID;
                    else
                        id = Convert.ToInt32(cbPaisOrigen.SelectedValue);

                    CargarCiudadPaisOrigen(id);
                }
                else
                {
                    //MessageBox.Show("Seleccione un Pais de Origen");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void cbPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {          

            try
            {
                if (cbPaisDestino.Items.Count > 0 && cbPaisDestino.SelectedIndex >= 0)
                {
                    int id = 0;
                    if (cbPaisDestino.SelectedValue.GetType() == typeof(AppAgenciaViajes.AgenciaServiceReference.Pais))
                        id = ((AppAgenciaViajes.AgenciaServiceReference.Pais)cbPaisDestino.SelectedValue).PaisID;
                    else
                        id = Convert.ToInt32(cbPaisDestino.SelectedValue);

                    CargarCiudadPaisDestino(id);
                }
                else
                {
                    MessageBox.Show("Seleccione un Pais de Destino");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public void CargarCiudadOrigen(int PaisID)
        //{
        //    try
        //    {
        //        CiudadServiceReference.SvcCiudadClient clientCiudad = new CiudadServiceReference.SvcCiudadClient();
        //        var data = clientCiudad.Consultar();
        //        data = data.Where(s=> s.PaisID==PaisID).ToList();
        //        cbCiudadOrigen.DataSource = data;
        //        cbCiudadOrigen.ValueMember = "CiudadID";
        //        cbCiudadOrigen.DisplayMember = "CiudadNombre";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public void CargarPaisDestino()
        {
            try
            {

                AgenciaServiceReference.SvcPaisClient ClientPais = new AgenciaServiceReference.SvcPaisClient();
                cbPaisDestino.SelectedIndex = -1;
                var data = ClientPais.Consultar();
                cbPaisDestino.DataSource = data;
                cbPaisDestino.ValueMember = "PaisID";
                cbPaisDestino.DisplayMember = "PaisNombre";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarCiudadPaisDestino(int idPais)
        {
            try
            {
                CiudadServiceReference.SvcCiudadClient client = new CiudadServiceReference.SvcCiudadClient();
                var data = client.ConsultarCiudadXPais(idPais);
                cbCiudadDestino.SelectedIndex = -1;
                cbCiudadDestino.DataSource = data;
                cbCiudadDestino.ValueMember = "CiudadID";
                cbCiudadDestino.DisplayMember = "CiudadNombre";
            }
            catch (Exception)
            {

                throw;
            }
        }



        //public void CargarCiudadDestino(int PaisID)
        //{
        //    try
        //    {
        //        CiudadServiceReference.SvcCiudadClient clientCiudad = new CiudadServiceReference.SvcCiudadClient();
        //        var data = clientCiudad.Consultar();
        //        data = data.Where(s => s.PaisID == PaisID).ToList();
        //        cbCiudadDestino.DataSource = data;
        //        cbCiudadDestino.ValueMember = "CiudadID";
        //        cbCiudadDestino.DisplayMember = "CiudadNombre";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


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
                CargarResumen();
            }
        }

        private void CargarResumen()
        {
            gridResumenPasajero.DataSource = new List<ViajeServiceReference.Pasajero>() { objPasajero };
            gridResumenViaje.DataSource = new List<ViajeServiceReference.Viaje>() { objViaje };
            gridResumenMaleta.DataSource = objmaletas;
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


        public void CargarTipoServicio()
        {
            try
            {
                TipoServicioServiceReference.SvcTipoServicioClient client = new TipoServicioServiceReference.SvcTipoServicioClient();
                var data = client.Consultar();
                cboTipoServicio.DataSource = data;
                cboTipoServicio.ValueMember = "TipoServicioID";
                cboTipoServicio.DisplayMember = "TipoServicioNombre";
            }
            catch (Exception ex)
            {
                throw;
                //throw;
            }
        }


        #endregion

        private void btnContinuarDatosMaleta_Click(object sender, EventArgs e)
        {
            objmaletas = new List<ViajeServiceReference.Maleta>();
            for (int i = 0; i < gridMaletas.Rows.Count; i++)
            {
                var obj = new ViajeServiceReference.Maleta()
                {
                    MaletaAlto = Convert.ToDecimal(gridMaletas.Rows[i].Cells[0].Value),
                    MaletaLargo = Convert.ToDecimal(gridMaletas.Rows[i].Cells[1].Value),
                    MaletaAncho = Convert.ToDecimal(gridMaletas.Rows[i].Cells[2].Value),
                    MaletaPeso = Convert.ToDecimal(gridMaletas.Rows[i].Cells[3].Value),


                };

                
                objmaletas.Add(obj);

            }

            CargarResumen();

            tpViaje.TabPages.Clear();
            tpViaje.TabPages.Add(tpResumen);
        }

        private void btnViajeCancelar_Click(object sender, EventArgs e)
        {
            tpViaje.TabPages.Clear();
            tpViaje.TabPages.Add(tpDatosPasajero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tpViaje.TabPages.Clear();
            tpViaje.TabPages.Add(tpDatosPasajero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tpViaje.TabPages.Clear();
            if (objViaje.NumeroDeMaletas > 0)
            {
                tpViaje.TabPages.Add(tpMaleta);
            }
            else
            {
                tpViaje.TabPages.Add(tpDatosViaje);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tpViaje.TabPages.Clear();
            if (objViaje.NumeroDeMaletas > 0)
            {                
                tpViaje.TabPages.Add(tpMaleta);
            }
            else
            {
                tpViaje.TabPages.Add(tpDatosViaje);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ViajeServiceReference.SvcViajeClient ClientPasajero = new ViajeServiceReference.SvcViajeClient();

            objViaje.Pasajero = objPasajero;
            objPasajero.Maletas = objmaletas;
            objResMaleta = objmaletas;
            var data = ClientPasajero.Insertar(objViaje);
            if (data)
            {
                MessageBox.Show("Datos guardados exitosamente");
                button4.Enabled = false;
                button5.Enabled = false;
            }
                
            else
                MessageBox.Show("Error al enviar la reserva");


        }
    }
}
