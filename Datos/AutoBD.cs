using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class AutoBD
    {

        static BindingList<Auto> LstAuto;
        static OleDbConnection con;
        public static bool AgregarAuto(string NuevaRuta, string RutaUdl, Auto auto)
        {
            bool res = false;
            try
            {
                
                using (con= Conexion.getConexion(RutaUdl))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into Auto_Tab values(?,?,?,?,?,?)", con);
                    cmd.Parameters.AddWithValue("Marca", auto.Marca);
                    cmd.Parameters.AddWithValue("Modelo", auto.Modelo);
                    cmd.Parameters.AddWithValue("Anio", auto.Anio);
                    cmd.Parameters.AddWithValue("Precio", auto.Precio);
                    cmd.Parameters.AddWithValue("Fec_Vent", auto.Fec_Vent.Date);
                    cmd.Parameters.AddWithValue("Img", NuevaRuta);
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado >= 1)
                        res = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error en la inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            
            return res;
        }
       
        public static bool ModificarAuto(string RutaUdl, Auto auto)
        {
            bool res = false;
            try
            {
                using (con = Conexion.getConexion(RutaUdl))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Update Auto_Tab set Marca = ?,Modelo =?, Marca = ?,Anio =?, Precio = ?, Fec_Vent =? where IdAuto = ?", con);
                    cmd.Parameters.AddWithValue("Marca", auto.Marca);
                    cmd.Parameters.AddWithValue("Modelo", auto.Modelo);
                    cmd.Parameters.AddWithValue("Marca", auto.Anio);
                    cmd.Parameters.AddWithValue("Marca", auto.Precio);
                    cmd.Parameters.AddWithValue("Marca", auto.Fec_Vent);
                    cmd.Parameters.AddWithValue("Id", auto.Id);
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado >= 1)
                        res = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error en la modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        public static bool EliminarAuto(string RutaUdl, Auto auto)
        {
            bool res = false;
            try
            {
                using (con = Conexion.getConexion(RutaUdl))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("delete from Auto_Tab where Auto_Tab.IdAuto = ?", con);
                    cmd.Parameters.AddWithValue("IdAuto", auto.Id);
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado >= 1)
                        res = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        public static BindingList<Auto> getAuto(string RutaUdl)
        {
            Auto auto;
            try
            {
                using (con = Conexion.getConexion(RutaUdl))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("select * from Auto_Tab", con);
                    OleDbDataReader resultado = cmd.ExecuteReader();
                    LstAuto  = new BindingList<Auto>();
                    while (resultado.Read())
                    {
                        auto = new Auto();
                        auto.Id = Convert.ToInt32(resultado["IdAuto"]);
                        auto.Marca = resultado["Marca"].ToString();
                        auto.Modelo = resultado["Modelo"].ToString();
                        auto.Anio = Convert.ToInt32(resultado["Anio"]);
                        auto.Precio = Convert.ToDecimal(resultado["Precio"]);
                        auto.Fec_Vent = Convert.ToDateTime(resultado["Fec_Vent"]);
                        auto.img = resultado["Img"].ToString();
                        LstAuto.Add(auto);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error en la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return LstAuto;
        }

        public bool Delete(string RutaUdl, Auto a)
        {
            using (OleDbConnection con = Conexion.getConexion(RutaUdl))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("ElimPersona ?", con);
                cmd.Parameters.AddWithValue("id", a.Id);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado >= -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
