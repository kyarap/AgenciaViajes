
using System.Windows.Forms;

namespace AppAgenciaViajes
{
    partial class FrmPais
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrdPais = new System.Windows.Forms.DataGridView();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.BtnCancelarPais = new System.Windows.Forms.Button();
            this.btnPaisAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Pais";
            // 
            // GrdPais
            // 
            this.GrdPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPais.Location = new System.Drawing.Point(416, 29);
            this.GrdPais.Name = "GrdPais";
            this.GrdPais.Size = new System.Drawing.Size(443, 167);
            this.GrdPais.TabIndex = 4;
            this.GrdPais.Text = "dataGridView1";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(116, 86);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(187, 20);
            this.txtPais.TabIndex = 3;
            // 
            // BtnCancelarPais
            // 
            this.BtnCancelarPais.Location = new System.Drawing.Point(238, 166);
            this.BtnCancelarPais.Name = "BtnCancelarPais";
            this.BtnCancelarPais.Size = new System.Drawing.Size(64, 20);
            this.BtnCancelarPais.TabIndex = 2;
            this.BtnCancelarPais.Text = "Cancelar";
            this.BtnCancelarPais.UseVisualStyleBackColor = true;
            // 
            // btnPaisAceptar
            // 
            this.btnPaisAceptar.Location = new System.Drawing.Point(168, 166);
            this.btnPaisAceptar.Name = "btnPaisAceptar";
            this.btnPaisAceptar.Size = new System.Drawing.Size(64, 20);
            this.btnPaisAceptar.TabIndex = 1;
            this.btnPaisAceptar.Text = "Aceptar";
            this.btnPaisAceptar.UseVisualStyleBackColor = true;
            this.btnPaisAceptar.Click += new System.EventHandler(this.btnPaisAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPaisAceptar);
            this.Controls.Add(this.BtnCancelarPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.GrdPais);
            this.Controls.Add(this.label1);
            this.Name = "FrmPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPais";
            this.Load += new System.EventHandler(this.FrmPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnPaisAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelarPais;
    }
}