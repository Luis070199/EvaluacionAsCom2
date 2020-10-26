using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Conexion
    {
        public static OleDbConnection getConexion(String rutaUdl)
        {
            //generamos una variable de conecion 
            OleDbConnection myConnection = null;
            try
            {
                //generamos un variable que almacenara la ruta del archivo conexiones 
                myConnection = new OleDbConnection("File Name = " + rutaUdl + ";");
                //abrimos la conecxion
                myConnection.Open();
                //validamos si el estado se escuetar abierta 
                if (myConnection.State == ConnectionState.Open)
                {
                    //serraos la bariabñes de ls conexio
                    myConnection.Close();
                    //retornamod la varible con su estado
                    return myConnection;
                }
                else
                    //restornamos la c onexin
                    return myConnection = null;
            }
            catch (Exception ex)
            {
                return myConnection = null;
            }
        }
    }
}
