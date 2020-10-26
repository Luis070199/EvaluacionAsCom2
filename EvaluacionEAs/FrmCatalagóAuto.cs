using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace EvaluacionEAs
{
    public partial class FrmCatalagóAuto : Form
    {
        string RutaUDL = "";
        Auto auto = new Auto();
        BindingList<Auto> lstAutos;
        private string rutaUDL;
        List<Auto> lstEncontrados;
        decimal res = 1;
        decimal num = 0;


        public FrmCatalagóAuto()
        {
            InitializeComponent();
            panel1.AutoScrollPosition = AutoScrollPosition;
            RutaUDL = Directory.GetCurrentDirectory();
            RutaUDL += "\\conexion.udl";
            this.WindowState = FormWindowState.Maximized;
            DgvDatos1.AutoGenerateColumns = false;
            lstAutos = AutosBL.GetAutos(RutaUDL);
           
            
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Abrir("");

        }
       public void Ba()
        {

        }

        private void Cargar()
        {
            lstAutos = AutosBL.GetAutos(RutaUDL);
            bsDatos.DataSource = lstAutos;
            DgvDatos1.DataSource = bsDatos;
        }

        private void Abrir(string acción)
        {
            FrmAltaModAuto frmAltaModAuto;
            if (acción != "")
            {
                auto = (Auto)bsDatos.Current;
                frmAltaModAuto = new FrmAltaModAuto(RutaUDL, auto);
                frmAltaModAuto.ShowDialog();
                if (frmAltaModAuto.DialogResult == DialogResult.OK)
                    Cargar();
            }
            else
            {
                frmAltaModAuto = new FrmAltaModAuto(RutaUDL, null);
                frmAltaModAuto.ShowDialog();
                if (frmAltaModAuto.DialogResult == DialogResult.OK)
                    Cargar();
            }

        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Abrir("Actualizar");
            //BindingList<Auto> Lstautos
            //foreach(Auto auto in DtgDatos2.SelectedCells)
            //{
                
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String op = MessageBox.Show("¿Deseas eliminar el registro?", "Mensaje de confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1).ToString();
            if (op.Equals("Yes"))
            {
                auto = (Auto)bsDatos.Current;
                if (AutosBL.EliminarAutos(RutaUDL, auto))
                    Cargar();
            }
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {


            if (txtBusqueda.Text != "")
            {
                
                //var alumnosC = listadealumnos.Where(a => a.Grupo == "C");
                var Buscar = txtBusqueda.Text.Trim();
                if (CbFiltro.SelectedText == "Todos los campos")
                {
                    lstEncontrados = lstAutos.
                    Where(Aut => (
                    Aut.Id + "").Contains(Buscar)
                    || Aut.Marca.ToLower().Contains(Buscar.ToLower())
                    || Aut.Modelo.ToLower().Contains(Buscar.ToLower())
                    || Aut.Anio.ToString().Contains(Buscar.ToLower())
                    || (Aut.Fec_Vent + "").Contains(Buscar.ToLower())).ToList();
                }
                else if(CbFiltro.SelectedText == "Id")
                {
                    lstEncontrados = lstAutos.
                    Where(Aut => (
                    Aut.Id + "").Contains(Buscar)).ToList();
                }
                else if (CbFiltro.SelectedText == "Marca")
                {
                    lstEncontrados = lstAutos.
                     Where(Aut =>  Aut.Marca.ToLower().Contains(Buscar.ToLower())).ToList();
                }
                else if (CbFiltro.SelectedText == "Modelo")
                {
                    lstEncontrados = lstAutos.
                    Where(Aut => Aut.Modelo.ToLower().Contains(Buscar.ToLower())).ToList();
                }
                else if (CbFiltro.SelectedText == "Anio")
                {
                    lstEncontrados = lstAutos.
                     Where(Aut => Aut.Fec_Vent.ToString().Contains(Buscar.ToLower())).ToList();
                }
               

                bsDatos.DataSource = lstEncontrados;
                DgvDatos1.DataSource = bsDatos;

            }
            else
            {
                Cargar();
            }
        }

        private void CbFiltro_TextChanged(object sender, EventArgs e)
        {
            //Filtrar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargar();
            txtBusqueda.Text.Equals("");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Minimized;
            
               
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //DateTime start = DateTime.Now;
            //e.Result = "";
            BindingList<Auto> ListaNew = new BindingList<Auto>();
            
            num = lstAutos.Count();
            num = 100 / num;
            foreach (Auto auto in lstAutos)
            {
                
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(Convert.ToInt32(num*res));
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break; 
                }
            }

            //TimeSpan duration = DateTime.Now - start;
            //e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblPorcentaje.Text = e.ProgressPercentage + "%";
            res++;
            //actualizamos la barra de progreso
            //DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede

            ////en este ejemplo, logamos a un textbox
            //txtOutput.AppendText(time.ToLongTimeString());
            //txtOutput.AppendText(Environment.NewLine);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Accion Canclada");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());
            }
            else
            {
                progressBar1.Value = 100;
                panel1.Visible = false;

                //MessageBox.Show("completado " + e.Result.ToString());
            }
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }
    }
}
