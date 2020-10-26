namespace EvaluacionEAs
{
    partial class FrmAltaModAuto
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbFec_Venta = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.DtFec_Venta = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.ptbImg = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta / Modificacion Autos";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(137, 79);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(131, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(45, 82);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 2;
            this.lbMarca.Text = "Marca";
            // 
            // lbFec_Venta
            // 
            this.lbFec_Venta.AutoSize = true;
            this.lbFec_Venta.Location = new System.Drawing.Point(45, 238);
            this.lbFec_Venta.Name = "lbFec_Venta";
            this.lbFec_Venta.Size = new System.Drawing.Size(68, 13);
            this.lbFec_Venta.TabIndex = 4;
            this.lbFec_Venta.Text = "Fecha Venta";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(45, 198);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(45, 160);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(28, 13);
            this.lbAnio.TabIndex = 8;
            this.lbAnio.Text = "Anio";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(137, 157);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(131, 20);
            this.txtAnio.TabIndex = 7;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(45, 117);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 10;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(137, 114);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(131, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // DtFec_Venta
            // 
            this.DtFec_Venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFec_Venta.Location = new System.Drawing.Point(137, 238);
            this.DtFec_Venta.Name = "DtFec_Venta";
            this.DtFec_Venta.Size = new System.Drawing.Size(131, 20);
            this.DtFec_Venta.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(312, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(415, 264);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // NumPrecio
            // 
            this.NumPrecio.Location = new System.Drawing.Point(137, 198);
            this.NumPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(131, 20);
            this.NumPrecio.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(458, 235);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(41, 23);
            this.btnAbrir.TabIndex = 16;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(282, 238);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(170, 20);
            this.txtRuta.TabIndex = 19;
            // 
            // ptbImg
            // 
            this.ptbImg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbImg.Location = new System.Drawing.Point(282, 79);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.Size = new System.Drawing.Size(217, 143);
            this.ptbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImg.TabIndex = 15;
            this.ptbImg.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::EvaluacionEAs.Properties.Resources.eliminar__3_;
            this.btnCerrar.Location = new System.Drawing.Point(478, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAltaModAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 293);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.ptbImg);
            this.Controls.Add(this.NumPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DtFec_Venta);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbFec_Venta);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaModAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaModAuto";
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbFec_Venta;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DateTimePicker DtFec_Venta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ptbImg;
        private System.Windows.Forms.Button btnAbrir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnCerrar;
    }
}