
namespace AppAgenciaViajes
{
    partial class FrmDatosViaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpViaje = new System.Windows.Forms.TabControl();
            this.tpDatosPasajero = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.btnPasajeroCancelar = new System.Windows.Forms.Button();
            this.btnPasajeroAceptar = new System.Windows.Forms.Button();
            this.txtPsjCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtPsjApellido = new System.Windows.Forms.TextBox();
            this.txtPsjNombre = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDatosViaje = new System.Windows.Forms.TabPage();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnViajeAceptar = new System.Windows.Forms.Button();
            this.nudMaletas = new System.Windows.Forms.NumericUpDown();
            this.btnViajeCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPaisDestino = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.tpMaleta = new System.Windows.Forms.TabPage();
            this.gridMaletas = new System.Windows.Forms.DataGridView();
            this.Alto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.btnContinuarDatosMaleta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tpServAdicional = new System.Windows.Forms.TabPage();
            this.txtServAdicional = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tpResumen = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gridResumenMaleta = new System.Windows.Forms.DataGridView();
            this.gridResumenViaje = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.gridResumenPasajero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tpViaje.SuspendLayout();
            this.tpDatosPasajero.SuspendLayout();
            this.tpDatosViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaletas)).BeginInit();
            this.tpMaleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaletas)).BeginInit();
            this.tpServAdicional.SuspendLayout();
            this.tpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenMaleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // tpViaje
            // 
            this.tpViaje.Controls.Add(this.tpDatosPasajero);
            this.tpViaje.Controls.Add(this.tpDatosViaje);
            this.tpViaje.Controls.Add(this.tpMaleta);
            this.tpViaje.Controls.Add(this.tpServAdicional);
            this.tpViaje.Controls.Add(this.tpResumen);
            this.tpViaje.Location = new System.Drawing.Point(10, 30);
            this.tpViaje.Name = "tpViaje";
            this.tpViaje.SelectedIndex = 2;
            this.tpViaje.Size = new System.Drawing.Size(665, 349);
            this.tpViaje.TabIndex = 0;
            // 
            // tpDatosPasajero
            // 
            this.tpDatosPasajero.Controls.Add(this.label18);
            this.tpDatosPasajero.Controls.Add(this.btnPasajeroCancelar);
            this.tpDatosPasajero.Controls.Add(this.btnPasajeroAceptar);
            this.tpDatosPasajero.Controls.Add(this.txtPsjCorreo);
            this.tpDatosPasajero.Controls.Add(this.txtTelefono);
            this.tpDatosPasajero.Controls.Add(this.txtNumDocumento);
            this.tpDatosPasajero.Controls.Add(this.txtPsjApellido);
            this.tpDatosPasajero.Controls.Add(this.txtPsjNombre);
            this.tpDatosPasajero.Controls.Add(this.cboTipoDocumento);
            this.tpDatosPasajero.Controls.Add(this.label7);
            this.tpDatosPasajero.Controls.Add(this.label6);
            this.tpDatosPasajero.Controls.Add(this.label5);
            this.tpDatosPasajero.Controls.Add(this.label4);
            this.tpDatosPasajero.Controls.Add(this.label3);
            this.tpDatosPasajero.Controls.Add(this.label2);
            this.tpDatosPasajero.Location = new System.Drawing.Point(4, 22);
            this.tpDatosPasajero.Name = "tpDatosPasajero";
            this.tpDatosPasajero.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosPasajero.Size = new System.Drawing.Size(657, 323);
            this.tpDatosPasajero.TabIndex = 0;
            this.tpDatosPasajero.Text = "Datos del Pasajero";
            this.tpDatosPasajero.UseVisualStyleBackColor = true;
            this.tpDatosPasajero.Click += new System.EventHandler(this.tpDatosPasajero_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(376, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 27);
            this.label18.TabIndex = 8;
            this.label18.Text = "Paso 1";
            // 
            // btnPasajeroCancelar
            // 
            this.btnPasajeroCancelar.Location = new System.Drawing.Point(567, 256);
            this.btnPasajeroCancelar.Name = "btnPasajeroCancelar";
            this.btnPasajeroCancelar.Size = new System.Drawing.Size(64, 29);
            this.btnPasajeroCancelar.TabIndex = 3;
            this.btnPasajeroCancelar.Text = "Cancelar";
            this.btnPasajeroCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPasajeroAceptar
            // 
            this.btnPasajeroAceptar.Location = new System.Drawing.Point(472, 256);
            this.btnPasajeroAceptar.Name = "btnPasajeroAceptar";
            this.btnPasajeroAceptar.Size = new System.Drawing.Size(64, 29);
            this.btnPasajeroAceptar.TabIndex = 7;
            this.btnPasajeroAceptar.Text = "Aceptar";
            this.btnPasajeroAceptar.UseVisualStyleBackColor = true;
            this.btnPasajeroAceptar.Click += new System.EventHandler(this.btnPasajeroAceptar_Click);
            // 
            // txtPsjCorreo
            // 
            this.txtPsjCorreo.Location = new System.Drawing.Point(286, 213);
            this.txtPsjCorreo.Name = "txtPsjCorreo";
            this.txtPsjCorreo.Size = new System.Drawing.Size(184, 20);
            this.txtPsjCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(286, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(286, 148);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(184, 20);
            this.txtNumDocumento.TabIndex = 4;
            this.txtNumDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumento_KeyPress);
            // 
            // txtPsjApellido
            // 
            this.txtPsjApellido.Location = new System.Drawing.Point(286, 77);
            this.txtPsjApellido.Name = "txtPsjApellido";
            this.txtPsjApellido.Size = new System.Drawing.Size(184, 20);
            this.txtPsjApellido.TabIndex = 2;
            // 
            // txtPsjNombre
            // 
            this.txtPsjNombre.Location = new System.Drawing.Point(286, 43);
            this.txtPsjNombre.Name = "txtPsjNombre";
            this.txtPsjNombre.Size = new System.Drawing.Size(184, 20);
            this.txtPsjNombre.TabIndex = 1;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(286, 107);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(184, 21);
            this.cboTipoDocumento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num. de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // tpDatosViaje
            // 
            this.tpDatosViaje.Controls.Add(this.cboTipoServicio);
            this.tpDatosViaje.Controls.Add(this.label22);
            this.tpDatosViaje.Controls.Add(this.label19);
            this.tpDatosViaje.Controls.Add(this.dateTimePicker1);
            this.tpDatosViaje.Controls.Add(this.label17);
            this.tpDatosViaje.Controls.Add(this.btnViajeAceptar);
            this.tpDatosViaje.Controls.Add(this.nudMaletas);
            this.tpDatosViaje.Controls.Add(this.btnViajeCancelar);
            this.tpDatosViaje.Controls.Add(this.label12);
            this.tpDatosViaje.Controls.Add(this.cbPaisDestino);
            this.tpDatosViaje.Controls.Add(this.label11);
            this.tpDatosViaje.Controls.Add(this.cbCiudadDestino);
            this.tpDatosViaje.Controls.Add(this.label10);
            this.tpDatosViaje.Controls.Add(this.label9);
            this.tpDatosViaje.Controls.Add(this.cbCiudadOrigen);
            this.tpDatosViaje.Controls.Add(this.label8);
            this.tpDatosViaje.Controls.Add(this.cbPaisOrigen);
            this.tpDatosViaje.Location = new System.Drawing.Point(4, 22);
            this.tpDatosViaje.Name = "tpDatosViaje";
            this.tpDatosViaje.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosViaje.Size = new System.Drawing.Size(657, 323);
            this.tpDatosViaje.TabIndex = 1;
            this.tpDatosViaje.Text = "Datos del viaje";
            this.tpDatosViaje.UseVisualStyleBackColor = true;
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(195, 197);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(223, 21);
            this.cboTipoServicio.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(74, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Tipo de Servicio";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(373, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 27);
            this.label19.TabIndex = 9;
            this.label19.Text = "Paso 2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fecha de viaje";
            // 
            // btnViajeAceptar
            // 
            this.btnViajeAceptar.Location = new System.Drawing.Point(494, 272);
            this.btnViajeAceptar.Name = "btnViajeAceptar";
            this.btnViajeAceptar.Size = new System.Drawing.Size(64, 31);
            this.btnViajeAceptar.TabIndex = 7;
            this.btnViajeAceptar.Text = "Aceptar";
            this.btnViajeAceptar.UseVisualStyleBackColor = true;
            this.btnViajeAceptar.Click += new System.EventHandler(this.btnViajeAceptar_Click);
            // 
            // nudMaletas
            // 
            this.nudMaletas.Location = new System.Drawing.Point(196, 231);
            this.nudMaletas.Name = "nudMaletas";
            this.nudMaletas.Size = new System.Drawing.Size(103, 20);
            this.nudMaletas.TabIndex = 5;
            // 
            // btnViajeCancelar
            // 
            this.btnViajeCancelar.Location = new System.Drawing.Point(575, 272);
            this.btnViajeCancelar.Name = "btnViajeCancelar";
            this.btnViajeCancelar.Size = new System.Drawing.Size(64, 31);
            this.btnViajeCancelar.TabIndex = 3;
            this.btnViajeCancelar.Text = "Atrás";
            this.btnViajeCancelar.UseVisualStyleBackColor = true;
            this.btnViajeCancelar.Click += new System.EventHandler(this.btnViajeCancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Núm. de Maletas";
            // 
            // cbPaisDestino
            // 
            this.cbPaisDestino.FormattingEnabled = true;
            this.cbPaisDestino.Location = new System.Drawing.Point(195, 128);
            this.cbPaisDestino.Name = "cbPaisDestino";
            this.cbPaisDestino.Size = new System.Drawing.Size(223, 21);
            this.cbPaisDestino.TabIndex = 3;
            this.cbPaisDestino.SelectedIndexChanged += new System.EventHandler(this.cbPaisDestino_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pais de Destino";
            // 
            // cbCiudadDestino
            // 
            this.cbCiudadDestino.FormattingEnabled = true;
            this.cbCiudadDestino.Location = new System.Drawing.Point(195, 162);
            this.cbCiudadDestino.Name = "cbCiudadDestino";
            this.cbCiudadDestino.Size = new System.Drawing.Size(223, 21);
            this.cbCiudadDestino.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ciudad de Destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ciudad de Origen";
            // 
            // cbCiudadOrigen
            // 
            this.cbCiudadOrigen.FormattingEnabled = true;
            this.cbCiudadOrigen.Location = new System.Drawing.Point(195, 93);
            this.cbCiudadOrigen.Name = "cbCiudadOrigen";
            this.cbCiudadOrigen.Size = new System.Drawing.Size(223, 21);
            this.cbCiudadOrigen.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pais de Origen";
            // 
            // cbPaisOrigen
            // 
            this.cbPaisOrigen.FormattingEnabled = true;
            this.cbPaisOrigen.Location = new System.Drawing.Point(195, 58);
            this.cbPaisOrigen.Name = "cbPaisOrigen";
            this.cbPaisOrigen.Size = new System.Drawing.Size(223, 21);
            this.cbPaisOrigen.TabIndex = 1;
            this.cbPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cbPaisOrigen_SelectedIndexChanged);
            // 
            // tpMaleta
            // 
            this.tpMaleta.Controls.Add(this.gridMaletas);
            this.tpMaleta.Controls.Add(this.label20);
            this.tpMaleta.Controls.Add(this.btnContinuarDatosMaleta);
            this.tpMaleta.Controls.Add(this.button3);
            this.tpMaleta.Location = new System.Drawing.Point(4, 22);
            this.tpMaleta.Name = "tpMaleta";
            this.tpMaleta.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaleta.Size = new System.Drawing.Size(657, 323);
            this.tpMaleta.TabIndex = 2;
            this.tpMaleta.Text = "Datos de la Maleta";
            this.tpMaleta.UseVisualStyleBackColor = true;
            // 
            // gridMaletas
            // 
            this.gridMaletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMaletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alto,
            this.Largo,
            this.Ancho,
            this.Peso});
            this.gridMaletas.Location = new System.Drawing.Point(23, 59);
            this.gridMaletas.Name = "gridMaletas";
            this.gridMaletas.Size = new System.Drawing.Size(566, 150);
            this.gridMaletas.TabIndex = 16;
            // 
            // Alto
            // 
            this.Alto.HeaderText = "Alto";
            this.Alto.Name = "Alto";
            this.Alto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Alto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Largo
            // 
            this.Largo.HeaderText = "Largo";
            this.Largo.Name = "Largo";
            // 
            // Ancho
            // 
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.Name = "Ancho";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(377, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 27);
            this.label20.TabIndex = 9;
            this.label20.Text = "Paso 3";
            // 
            // btnContinuarDatosMaleta
            // 
            this.btnContinuarDatosMaleta.Location = new System.Drawing.Point(479, 270);
            this.btnContinuarDatosMaleta.Name = "btnContinuarDatosMaleta";
            this.btnContinuarDatosMaleta.Size = new System.Drawing.Size(83, 29);
            this.btnContinuarDatosMaleta.TabIndex = 3;
            this.btnContinuarDatosMaleta.Text = "Continuar";
            this.btnContinuarDatosMaleta.UseVisualStyleBackColor = true;
            this.btnContinuarDatosMaleta.Click += new System.EventHandler(this.btnContinuarDatosMaleta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tpServAdicional
            // 
            this.tpServAdicional.Controls.Add(this.txtServAdicional);
            this.tpServAdicional.Controls.Add(this.label15);
            this.tpServAdicional.Controls.Add(this.button1);
            this.tpServAdicional.Controls.Add(this.button2);
            this.tpServAdicional.Controls.Add(this.label13);
            this.tpServAdicional.Location = new System.Drawing.Point(4, 22);
            this.tpServAdicional.Name = "tpServAdicional";
            this.tpServAdicional.Padding = new System.Windows.Forms.Padding(3);
            this.tpServAdicional.Size = new System.Drawing.Size(657, 323);
            this.tpServAdicional.TabIndex = 4;
            this.tpServAdicional.Text = "Servicio Adicional";
            this.tpServAdicional.UseVisualStyleBackColor = true;
            // 
            // txtServAdicional
            // 
            this.txtServAdicional.Location = new System.Drawing.Point(206, 58);
            this.txtServAdicional.Multiline = true;
            this.txtServAdicional.Name = "txtServAdicional";
            this.txtServAdicional.Size = new System.Drawing.Size(226, 44);
            this.txtServAdicional.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Servicio Adicional";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(380, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 27);
            this.label13.TabIndex = 10;
            this.label13.Text = "Paso 4";
            // 
            // tpResumen
            // 
            this.tpResumen.Controls.Add(this.button4);
            this.tpResumen.Controls.Add(this.button5);
            this.tpResumen.Controls.Add(this.gridResumenMaleta);
            this.tpResumen.Controls.Add(this.gridResumenViaje);
            this.tpResumen.Controls.Add(this.label14);
            this.tpResumen.Controls.Add(this.gridResumenPasajero);
            this.tpResumen.Location = new System.Drawing.Point(4, 22);
            this.tpResumen.Name = "tpResumen";
            this.tpResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tpResumen.Size = new System.Drawing.Size(657, 323);
            this.tpResumen.TabIndex = 3;
            this.tpResumen.Text = "Resumen";
            this.tpResumen.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(471, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "Atrás";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gridResumenMaleta
            // 
            this.gridResumenMaleta.AllowUserToAddRows = false;
            this.gridResumenMaleta.AllowUserToDeleteRows = false;
            this.gridResumenMaleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumenMaleta.Location = new System.Drawing.Point(21, 201);
            this.gridResumenMaleta.Name = "gridResumenMaleta";
            this.gridResumenMaleta.Size = new System.Drawing.Size(603, 82);
            this.gridResumenMaleta.TabIndex = 13;
            this.gridResumenMaleta.Text = "dataGridView4";
            // 
            // gridResumenViaje
            // 
            this.gridResumenViaje.AllowUserToAddRows = false;
            this.gridResumenViaje.AllowUserToDeleteRows = false;
            this.gridResumenViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumenViaje.Location = new System.Drawing.Point(21, 114);
            this.gridResumenViaje.Name = "gridResumenViaje";
            this.gridResumenViaje.Size = new System.Drawing.Size(603, 81);
            this.gridResumenViaje.TabIndex = 12;
            this.gridResumenViaje.Text = "dataGridView3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(375, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 27);
            this.label14.TabIndex = 11;
            this.label14.Text = "Paso 5";
            // 
            // gridResumenPasajero
            // 
            this.gridResumenPasajero.AllowUserToAddRows = false;
            this.gridResumenPasajero.AllowUserToDeleteRows = false;
            this.gridResumenPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumenPasajero.Location = new System.Drawing.Point(21, 33);
            this.gridResumenPasajero.Name = "gridResumenPasajero";
            this.gridResumenPasajero.Size = new System.Drawing.Size(603, 75);
            this.gridResumenPasajero.TabIndex = 5;
            this.gridResumenPasajero.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitud de Viaje";
            // 
            // FrmDatosViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tpViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "FrmDatosViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes ";
            this.Load += new System.EventHandler(this.FrmDatosViaje_Load);
            this.tpViaje.ResumeLayout(false);
            this.tpDatosPasajero.ResumeLayout(false);
            this.tpDatosPasajero.PerformLayout();
            this.tpDatosViaje.ResumeLayout(false);
            this.tpDatosViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaletas)).EndInit();
            this.tpMaleta.ResumeLayout(false);
            this.tpMaleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaletas)).EndInit();
            this.tpServAdicional.ResumeLayout(false);
            this.tpServAdicional.PerformLayout();
            this.tpResumen.ResumeLayout(false);
            this.tpResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenMaleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenPasajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TabControl tpViaje;
        private System.Windows.Forms.TabPage tpDatosPasajero;
        private System.Windows.Forms.TabPage tpDatosViaje;
        private System.Windows.Forms.Button btnPasajeroCancelar;
        private System.Windows.Forms.Button btnPasajeroAceptar;
        private System.Windows.Forms.TextBox txtPsjCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.TextBox txtPsjApellido;
        private System.Windows.Forms.TextBox txtPsjNombre;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaletas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPaisDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCiudadDestino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCiudadOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPaisOrigen;
        private System.Windows.Forms.TabPage tpMaleta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnViajeAceptar;
        private System.Windows.Forms.Button btnViajeCancelar;
        private System.Windows.Forms.Button btnContinuarDatosMaleta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tpResumen;
        private System.Windows.Forms.DataGridView gridResumenPasajero;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView gridMaletas;
        private System.Windows.Forms.TabPage tpServAdicional;
        private System.Windows.Forms.TextBox txtServAdicional;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gridResumenMaleta;
        private System.Windows.Forms.DataGridView gridResumenViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}