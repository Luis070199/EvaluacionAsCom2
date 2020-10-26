using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class AutosBL
    {
       public static bool AgregarAutos(string NuevaRuta, string RutaUdl, Auto auto)
        {
            return AutoBD.AgregarAuto(NuevaRuta, RutaUdl, auto);
        }
        public static bool ModificarAutos(string RutaUdl, Auto auto)
        {
            return AutoBD.ModificarAuto(RutaUdl, auto);
        }
        public static bool EliminarAutos(string RutaUdl, Auto auto)
        {
            return AutoBD.EliminarAuto(RutaUdl, auto);
        }
        public static BindingList<Auto> GetAutos(string RutaUdl)
        {
            return AutoBD.getAuto(RutaUdl);
        }
    }
}
