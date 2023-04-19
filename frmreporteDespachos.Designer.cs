namespace Inventario
{
    partial class frmreporteDespachos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInforme = new System.Windows.Forms.Button();
            this.rptinformedespachos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnvolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnvolver);
            this.panel1.Controls.Add(this.btnInforme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnInforme
            // 
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Location = new System.Drawing.Point(514, 25);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(145, 48);
            this.btnInforme.TabIndex = 0;
            this.btnInforme.Text = "Generar Reporte";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // rptinformedespachos
            // 
            this.rptinformedespachos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptinformedespachos.Location = new System.Drawing.Point(0, 100);
            this.rptinformedespachos.Margin = new System.Windows.Forms.Padding(0);
            this.rptinformedespachos.Name = "rptinformedespachos";
            this.rptinformedespachos.ServerReport.BearerToken = null;
            this.rptinformedespachos.Size = new System.Drawing.Size(800, 251);
            this.rptinformedespachos.TabIndex = 1;
            // 
            // btnvolver
            // 
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Image = global::Inventario.Properties.Resources.regreso;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver.Location = new System.Drawing.Point(354, 25);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(104, 48);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "Volver Menu";
            this.btnvolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventario.Properties.Resources.logo_synergy;
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmreporteDespachos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.rptinformedespachos);
            this.Controls.Add(this.panel1);
            this.Name = "frmreporteDespachos";
            this.Text = "frmreporteDespachos";
            this.Load += new System.EventHandler(this.frmreporteDespachos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInforme;
        private Microsoft.Reporting.WinForms.ReportViewer rptinformedespachos;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}