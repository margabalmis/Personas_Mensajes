using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas_Mensajes.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas_Mensajes.vistas_modelos
{
    class NuevaPersonaVM : ObservableRecipient
    {
        private readonly NavegacionService servicio;
        public RelayCommand VentanaAñadirNacionalidad { get; }
        public RelayCommand AñadirPersona { get; }

        public NuevaPersonaVM()
        {
            servicio = new NavegacionService();
            NuevaPersona = new Persona();
            VentanaAñadirNacionalidad = new RelayCommand(AñadirNacionalidad);
            AñadirPersona = new RelayCommand(AddPerson);
            Nacionalidades = new ObservableCollection<string> { "Española", "Italiana", "Portuguesa", "Francesa" };
            WeakReferenceMessenger.Default.Register<AñadirNacionalidadMessage>
                (this, (r, m) =>
                {
                    Nacionalidades.Add(m.Value);
                });
        }

        private void AddPerson()
        {
            WeakReferenceMessenger.Default.Send(new AñadirPersonaMessage(NuevaPersona));
        }

        private ObservableCollection<string> nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }
        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }
        public void AñadirNacionalidad()
        {
            servicio.CargarDialogoNacionalidad();
        }
    }
}