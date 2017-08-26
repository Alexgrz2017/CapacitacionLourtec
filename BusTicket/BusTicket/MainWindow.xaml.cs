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
using BusTicket.Models;
namespace BusTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { public Reserva Reserva { get; set; }
      public List<Rutas> Rutas { get; set; }
      public List<Localizacion> Estaciones { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.Origen.ItemsSource = Estaciones;
            this.Origen.SelectedItem = Reserva.Salida;

            this.Destino.ItemsSource = Estaciones;
            this.Destino.SelectedItem = Reserva.Destino;

            this.Fecha.SelectedDate = DateTime.Now;
        }
    }
}
