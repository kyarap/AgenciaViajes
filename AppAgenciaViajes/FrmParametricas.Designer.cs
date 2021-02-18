
namespace AppAgenciaViajes
{
    partial class FrmParametricas
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
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.btnTipoServicio = new System.Windows.Forms.Button();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(121, 90);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(129, 43);
            this.btnAgregarPais.TabIndex = 1;
            this.btnAgregarPais.Text = "Agregar Pais";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // btnTipoServicio
            // 
            this.btnTipoServicio.Location = new System.Drawing.Point(121, 191);
            this.btnTipoServicio.Name = "btnTipoServicio";
            this.btnTipoServicio.Size = new System.Drawing.Size(129, 43);
            this.btnTipoServicio.TabIndex = 2;
            this.btnTipoServicio.Text = "Agregar Tipo de Servicio";
            this.btnTipoServicio.UseVisualStyleBackColor = true;
            this.btnTipoServicio.Click += new System.EventHandler(this.btnTipoServicio_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.Location = new System.Drawing.Point(121, 142);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(129, 43);
            this.btnCiudad.TabIndex = 3;
            this.btnCiudad.Text = "Agregar Ciudad";
            this.btnCiudad.UseVisualStyleBackColor = true;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // FrmParametricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCiudad);
            this.Controls.Add(this.btnTipoServicio);
            this.Controls.Add(this.btnAgregarPais);
            this.Name = "FrmParametricas";
            this.Text = "Parametricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.Button btnTipoServicio;
        private System.Windows.Forms.Button btnCiudad;
    }
}