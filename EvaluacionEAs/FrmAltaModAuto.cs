using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionEAs
{
    public partial class FrmAltaModAuto : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        Auto auto;
        int IdAuto = 0;
        string RutaUdl = "";
        string Rutaimg = "";
        string nuevaRuta;
        string imgAlt = "";
        public FrmAltaModAuto()
        {
            InitializeComponent();
            Rutaimg = Directory.GetCurrentDirectory();
            Rutaimg += "\\img2\\";

        }
        public FrmAltaModAuto(string rutaUDL, Auto Auto) : this()
        {
            RutaUdl = rutaUDL;
            if (Auto != null)
            {
                IdAuto = Auto.Id;
                txtMarca.Text = Auto.Marca;
                txtModelo.Text = Auto.Modelo;
                txtAnio.Text = Auto.Anio + "";
                NumPrecio.Value = Auto.Precio;
                DtFec_Venta.Value = Auto.Fec_Vent.Date;
                txtRuta.Text = Auto.img;
                ptbImg.Image = Image.FromFile(txtRuta.Text);
                imgAlt = Auto.img;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }

        }

        private bool Guardar()
        {
            bool res = false;
            if (!Validar())
            {
                cargarDatos();
                if (IdAuto != 0)
                {
                    res = AutosBL.ModificarAutos(RutaUdl, auto);
                    if (res)
                        if(imgAlt != txtRuta.Text)
                            Mov();
                }
                else
                {
                    res = AutosBL.AgregarAutos(nuevaRuta, RutaUdl, auto);
                    if (res)
                        Mov();
                }
                    

            }
            return res;

        }

        private bool Validar()
        {
            bool res = false;
            if (txtMarca.Equals(""))
            {
                Mess();
                txtMarca.Focus();
                res = true;
            }
            else if (txtModelo.Equals(""))
            {
                Mess();
                txtModelo.Focus();
                res = true;
            }
            else if (txtAnio.Equals(""))
            {
                Mess();
                txtAnio.Focus();
                res = true;
            }
            else if (NumPrecio.Value == 0)
            {
                Mess();
                NumPrecio.Focus();
                res = true;
            }
            return res;
        }

        private void Mess()
        {
            MessageBox.Show("No se admite campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cargarDatos()
        {
            auto = new Auto();
            if (IdAuto != 0)
                auto.Id = IdAuto;
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            auto.Anio = Convert.ToInt32(txtAnio.Text);
            auto.Precio = NumPrecio.Value;
            auto.Fec_Vent = DtFec_Venta.Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void AbrirFormulario()
        {

            string name = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    name = openFileDialog.SafeFileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                }
            }
            txtRuta.Text = filePath;
            nuevaRuta = Rutaimg + name;
            ptbImg.Image = Image.FromFile(filePath);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirFormulario();
        }
        public void Mov()
        {
            nuevaRuta = Path.Combine(nuevaRuta);
            ptbImg.Image.Save(nuevaRuta, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
