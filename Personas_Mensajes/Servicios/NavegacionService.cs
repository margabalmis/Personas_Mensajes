using Personas_Mensajes.user_controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas_Mensajes.Servicios
{
    class NavegacionService
    {
        static ListaPersonasUserControl listaPersonas = new ListaPersonasUserControl();
        internal UserControl CargarVistaNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        internal UserControl CargarVistaListaPersonas()
        {
            return listaPersonas;
        }
        internal void CargarDialogoNacionalidad()
        {
            AñadirNacionalidadWindow nuevaVentana = new AñadirNacionalidadWindow();
            nuevaVentana.ShowDialog();
        }

        internal UserControl CargarVistaConsultarPersonas()
        {
            return new ConsultarPersonaUserControl();
        }
    }
}
    