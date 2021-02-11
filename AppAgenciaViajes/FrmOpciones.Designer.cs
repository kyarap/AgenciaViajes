
namespace AppAgenciaViajes
{
    partial class FrmOpciones
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
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(221, 185);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(129, 23);
            this.btnAgregarPais.TabIndex = 0;
            this.btnAgregarPais.Text = "Agregar Pais";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Location = new System.Drawing.Point(221, 230);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(129, 23);
            this.btnAgregarPasajero.TabIndex = 1;
            this.btnAgregarPasajero.Text = "Agregar Pasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu de Opciones";
            // 
            // FrmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarPasajero);
            this.Controls.Add(this.btnAgregarPais);
            this.Name = "FrmOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.Button btnAgregarPasajero;
        private System.Windows.Forms.Label label1;
    }
}