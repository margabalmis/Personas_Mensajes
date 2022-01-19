using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas_Mensajes.Servicios;
using System.Collections.ObjectModel;


namespace Personas_Mensajes.vistas_modelos
{
    class ListaPersonasVM : ObservableRecipient
    {

        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty ( ref personaSeleccionada, value); }
        }

        public ListaPersonasVM()
        {
            ListaPersonas = new ObservableCollection<Persona>
            {
                new Persona("Ana","32","Española"),
                new Persona("Sophie","22","Francesa"),
                new Persona("Francesca","32","Italiana")
            };

            WeakReferenceMessenger.Default.Register<ListaPersonasVM, PersonaAConsultarMessage>
                (this, (r, m) =>
                {
                    m.Reply(r.PersonaSeleccionada);
                });


            WeakReferenceMessenger.Default.Register<AñadirPersonaMessage>
                (this, (r, m) =>
                {
                    ListaPersonas.Add(m.Value);
                });
        }
    }
}