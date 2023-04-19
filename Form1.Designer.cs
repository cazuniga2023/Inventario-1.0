namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btndespacho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncrearticket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtsuministro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockSuministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpartnumber = new System.Windows.Forms.TextBox();
            this.reportedataset = new Inventario.reportedataset();
            this.despachosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtguia = new System.Windows.Forms.TextBox();
            this.txtcantidaddes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fechacreacion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.fechadespacho = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportedataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(143, 172);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(123, 20);
            this.txtserie.TabIndex = 2;
            // 
            // txtticket
            // 
            this.txtticket.Location = new System.Drawing.Point(143, 212);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(123, 20);
            this.txtticket.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(141, 443);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // btndespacho
            // 
            this.btndespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndespacho.Location = new System.Drawing.Point(18, 508);
            this.btndespacho.Name = "btndespacho";
            this.btndespacho.Size = new System.Drawing.Size(104, 32);
            this.btndespacho.TabIndex = 4;
            this.btndespacho.Text = "Despachar";
            this.btndespacho.UseVisualStyleBackColor = true;
            this.btndespacho.Click += new System.EventHandler(this.btndespacho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero Serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número Ticket:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // btncrearticket
            // 
            this.btncrearticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearticket.Location = new System.Drawing.Point(164, 508);
            this.btncrearticket.Name = "btncrearticket";
            this.btncrearticket.Size = new System.Drawing.Size(102, 32);
            this.btncrearticket.TabIndex = 8;
            this.btncrearticket.Text = "Crear N° Ticket";
            this.btncrearticket.UseVisualStyleBackColor = true;
            this.btncrearticket.Click += new System.EventHandler(this.btncrearticket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modelo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(143, 101);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(123, 20);
            this.txtmodelo.TabIndex = 0;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // txtsuministro
            // 
            this.txtsuministro.Location = new System.Drawing.Point(143, 138);
            this.txtsuministro.Name = "txtsuministro";
            this.txtsuministro.Size = new System.Drawing.Size(123, 20);
            this.txtsuministro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Suministro: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockSuministrosToolStripMenuItem,
            this.serieTicketToolStripMenuItem});
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // stockSuministrosToolStripMenuItem
            // 
            this.stockSuministrosToolStripMenuItem.Name = "stockSuministrosToolStripMenuItem";
            this.stockSuministrosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockSuministrosToolStripMenuItem.Text = "Stock Suministros";
            this.stockSuministrosToolStripMenuItem.Click += new System.EventHandler(this.stockSuministrosToolStripMenuItem_Click);
            // 
            // serieTicketToolStripMenuItem
            // 
            this.serieTicketToolStripMenuItem.Name = "serieTicketToolStripMenuItem";
            this.serieTicketToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.serieTicketToolStripMenuItem.Text = "Serie /Ticket";
            this.serieTicketToolStripMenuItem.Click += new System.EventHandler(this.serieTicketToolStripMenuItem_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Location = new System.Drawing.Point(294, 508);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(102, 32);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar Campos";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventario.Properties.Resources.logo_synergy;
            this.pictureBox1.Location = new System.Drawing.Point(359, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Inventario.Properties.Resources.icons8_search_24px;
            this.btn_buscar.Location = new System.Drawing.Point(294, 101);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(34, 23);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Part Number:";
            // 
            // txtpartnumber
            // 
            this.txtpartnumber.Location = new System.Drawing.Point(143, 248);
            this.txtpartnumber.Name = "txtpartnumber";
            this.txtpartnumber.Size = new System.Drawing.Size(123, 20);
            this.txtpartnumber.TabIndex = 4;
            // 
            // reportedataset
            // 
            this.reportedataset.DataSetName = "reportedataset";
            this.reportedataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // despachosBindingSource
            // 
            this.despachosBindingSource.DataMember = "despachos";
            this.despachosBindingSource.DataSource = this.reportedataset;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha Creación :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "N° Guia :";
            // 
            // txtguia
            // 
            this.txtguia.Location = new System.Drawing.Point(143, 321);
            this.txtguia.Name = "txtguia";
            this.txtguia.Size = new System.Drawing.Size(123, 20);
            this.txtguia.TabIndex = 6;
            // 
            // txtcantidaddes
            // 
            this.txtcantidaddes.Location = new System.Drawing.Point(143, 286);
            this.txtcantidaddes.Name = "txtcantidaddes";
            this.txtcantidaddes.Size = new System.Drawing.Size(123, 20);
            this.txtcantidaddes.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cantidad Despachada :";
            // 
            // fechacreacion
            // 
            this.fechacreacion.CustomFormat = "";
            this.fechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechacreacion.Location = new System.Drawing.Point(143, 362);
            this.fechacreacion.Name = "fechacreacion";
            this.fechacreacion.Size = new System.Drawing.Size(123, 20);
            this.fechacreacion.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha Despacho :";
            // 
            // fechadespacho
            // 
            this.fechadespacho.CustomFormat = "dd-MM-yyyy";
            this.fechadespacho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechadespacho.Location = new System.Drawing.Point(143, 411);
            this.fechadespacho.Name = "fechadespacho";
            this.fechadespacho.Size = new System.Drawing.Size(123, 20);
            this.fechadespacho.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(376, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Actualizar Datos  SQL Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fechadespacho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechacreacion);
            this.Controls.Add(this.txtcantidaddes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtguia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpartnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsuministro);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncrearticket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndespacho);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventario Suministros";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportedataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btndespacho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncrearticket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txtsuministro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockSuministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieTicketToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private reportedataset reportedataset;
        private System.Windows.Forms.BindingSource despachosBindingSource;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpartnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtguia;
        private System.Windows.Forms.TextBox txtcantidaddes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechacreacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechadespacho;
        private System.Windows.Forms.Button button1;
    }
}

