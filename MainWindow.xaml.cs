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

namespace Interfazlb
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> mispoblaciones = new List<Poblaciones>();

            mispoblaciones.Add(new Poblaciones() { Poblacion1 = "San José", Temperatura1 = 13, Poblacion2 = "Puntarenas", Temperatura2 = 15 });
            mispoblaciones.Add(new Poblaciones() { Poblacion1 = "Limón", Temperatura1 = 20, Poblacion2 = "Guanacaste", Temperatura2 = 14 });
            mispoblaciones.Add(new Poblaciones() { Poblacion1 = "Heredia", Temperatura1 = 13, Poblacion2 = "Alajuela", Temperatura2 = 15 });
            mispoblaciones.Add(new Poblaciones() { Poblacion1 = "San José", Temperatura1 = 13, Poblacion2 = "Cartago", Temperatura2 = 15 });

            listapoblaciones.ItemsSource = mispoblaciones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((listapoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listapoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                (listapoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listapoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
        }
    }
    public class Poblaciones
    {
        public String Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public String Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }
    }
}
