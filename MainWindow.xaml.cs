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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonConsumoMaterial_Click(object sender, RoutedEventArgs e)
        {
            ConsumoMaterial consumoMaterial = new ConsumoMaterial();
            consumoMaterial.Show();
        }

        private void BotonMaterial_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material();
            material.Show();
        }

        private void BotonTarea_Click(object sender, RoutedEventArgs e)
        {
            Tarea tarea = new Tarea();
            tarea.Show();
        }

        private void BotonProyecto_Click(object sender, RoutedEventArgs e)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.Show();
        }
    }
}
