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

namespace App1
{
    /// <summary>
    /// Lógica de interacción para Tarea.xaml
    /// </summary>
    public partial class Tarea : Window
    {
        public Tarea()
        {
            InitializeComponent();
        }

        private void BotonCrearTarea_Click(object sender, RoutedEventArgs e)
        {
            AgregarTarea agregarTarea = new AgregarTarea();
            agregarTarea.Show();
        }

        private void BotonModificarTarea_Click(object sender, RoutedEventArgs e)
        {
            ModificarTarea modificarTarea = new ModificarTarea();
            modificarTarea.Show();
        }
    }
}
