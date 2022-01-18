using Personas_Mensajes.vistas_modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personas_Mensajes
{
    /// <summary>
    /// Lógica de interacción para AñadirNacionalidadWindow.xaml
    /// </summary>
    public partial class AñadirNacionalidadWindow : Window
    {
        AñadirNacionalidadWindowVM vmNacionalidad;
        public AñadirNacionalidadWindow()
        {
            InitializeComponent();
            vmNacionalidad = new AñadirNacionalidadWindowVM();
            this.DataContext = vmNacionalidad;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vmNacionalidad.GuardarNacionalidad();
            DialogResult = true;

        }
    }
}