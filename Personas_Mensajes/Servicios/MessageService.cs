using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas_Mensajes.Servicios
{
    class AñadirNacionalidadMessage : ValueChangedMessage<string>
    {
        public AñadirNacionalidadMessage(string nacionalidad) : base(nacionalidad) { }
    }
    class AñadirPersonaMessage : ValueChangedMessage<Persona>
    {
        public AñadirPersonaMessage(Persona personaAñadida) : base(personaAñadida) { }
    }

    class PersonaAConsultarMessage : RequestMessage<Persona> { }
}
