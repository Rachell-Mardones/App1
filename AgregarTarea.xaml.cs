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
    /// Lógica de interacción para AgregarTarea.xaml
    /// </summary>
    public partial class AgregarTarea : Window
    {
        public AgregarTarea()
        {
            InitializeComponent();
        }

        private void BotonCrear_Click(object sender, RoutedEventArgs e)
        {
            //Conexion con la base de datos

            //Ingresar tarea a la base de datos
            //string crear = "INSERT INTO Tarea (Nombre, Estado, Avance, ProyectoId) VALUES ('"+Nombre.Text+"', '"+Estado.Text+"','"+Avance.Text+"','"+ProyectoId+"')";
        }
    }
}
