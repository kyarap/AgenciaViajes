
namespace AppAgenciaViajes
{
    partial class FrmTipoServicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTipoServicioAceptar = new System.Windows.Forms.Button();
            this.BtnTipoServicioCancelar = new System.Windows.Forms.Button();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.GrdTipoServicio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // btnTipoServicioAceptar
            // 
            this.btnTipoServicioAceptar.Location = new System.Drawing.Point(132, 168);
            this.btnTipoServicioAceptar.Name = "btnTipoServicioAceptar";
            this.btnTipoServicioAceptar.Size = new System.Drawing.Size(64, 20);
            this.btnTipoServicioAceptar.TabIndex = 7;
            this.btnTipoServicioAceptar.Text = "Aceptar";
            this.btnTipoServicioAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnTipoServicioCancelar
            // 
            this.BtnTipoServicioCancelar.Location = new System.Drawing.Point(202, 168);
            this.BtnTipoServicioCancelar.Name = "BtnTipoServicioCancelar";
            this.BtnTipoServicioCancelar.Size = new System.Drawing.Size(64, 20);
            this.BtnTipoServicioCancelar.TabIndex = 8;
            this.BtnTipoServicioCancelar.Text = "Cancelar";
            this.BtnTipoServicioCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Location = new System.Drawing.Point(80, 88);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(187, 20);
            this.txtTipoServicio.TabIndex = 9;
            // 
            // GrdTipoServicio
            // 
            this.GrdTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTipoServicio.Location = new System.Drawing.Point(380, 31);
            this.GrdTipoServicio.Name = "GrdTipoServicio";
            this.GrdTipoServicio.Size = new System.Drawing.Size(443, 167);
            this.GrdTipoServicio.TabIndex = 10;
            this.GrdTipoServicio.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Servicio";
            // 
            // FrmTipoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTipoServicioAceptar);
            this.Controls.Add(this.BtnTipoServicioCancelar);
            this.Controls.Add(this.txtTipoServicio);
            this.Controls.Add(this.GrdTipoServicio);
            this.Controls.Add(this.label1);
            this.Name = "FrmTipoServicio";
            this.Text = "FrmTipoServicio";
            ((System.ComponentModel.ISupportInitialize)(this.GrdTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTipoServicioAceptar;
        private System.Windows.Forms.Button BtnTipoServicioCancelar;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.DataGridView GrdTipoServicio;
        private System.Windows.Forms.Label label1;
    }
}