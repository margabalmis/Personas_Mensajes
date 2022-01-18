using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas_Mensajes.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas_Mensajes.vistas_modelos
{
    class MainWindowVM : ObservableRecipient
    {
        NavegacionService servicio;

        public RelayCommand NuevaPersonaCommand { get; }

        public RelayCommand ConsultarPersonaCommand { get; }
        public RelayCommand ListadoPersonasCommand { get; }

        private UserControl contenidoVista;

        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }



        public MainWindowVM()
        {
            servicio = new NavegacionService();
            NuevaPersonaCommand = new RelayCommand(CargarVistaNuevaPersona);
            ListadoPersonasCommand = new RelayCommand(CargarVistaListaPersonas);
            ConsultarPersonaCommand = new RelayCommand(CargarVistaConsultarPersona);
        }

        private void CargarVistaNuevaPersona()
        {
            ContenidoVista = servicio.CargarVistaNuevaPersona();
        }

        private void CargarVistaListaPersonas()
        {
            ContenidoVista = servicio.CargarVistaListaPersonas();
        }
        private void CargarVistaConsultarPersona()
        {
            ContenidoVista = servicio.CargarVistaConsultarPersonas();
        }
    }
}