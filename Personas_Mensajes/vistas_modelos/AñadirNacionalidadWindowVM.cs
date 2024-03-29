﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    class AñadirNacionalidadWindowVM : ObservableRecipient
    {
       
        public AñadirNacionalidadWindowVM()
        {


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
            set { nacionalidad = value; }
        }
        public void GuardarNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new AñadirNacionalidadMessage(Nacionalidad));
        }
    }
}

