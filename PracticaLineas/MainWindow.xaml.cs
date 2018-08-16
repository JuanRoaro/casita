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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Pasto
            plnLinea.Points.Add(new Point(0.0, 225.0));
            plnLinea.Points.Add(new Point(100.0, 225.0));
            plnLinea.Points.Add(new Point(120.0, 200.0));
            plnLinea.Points.Add(new Point(120.0, 225.0));
            plnLinea.Points.Add(new Point(145.0, 200.0));
            plnLinea.Points.Add(new Point(145.0, 225.0));
            plnLinea.Points.Add(new Point(800.0, 225.0));

            //Paredes
            plnLinea2.Points.Add(new Point(250.0, 225.0));
            plnLinea2.Points.Add(new Point(250.0, 100.0));
            plnLinea2.Points.Add(new Point(380.0, 100.0));
            plnLinea2.Points.Add(new Point(380.0, 225.0));

            //Puerta
            plnLinea3.Points.Add(new Point(330.0, 225.0));
            plnLinea3.Points.Add(new Point(330.0, 185.0));
            plnLinea3.Points.Add(new Point(290.0, 185.0));
            plnLinea3.Points.Add(new Point(290.0, 225.0));

            //Techo
            plnLinea4.Points.Add(new Point(250.0, 100.0));
            plnLinea4.Points.Add(new Point(310.0, 50.0));
            plnLinea4.Points.Add(new Point(380.0, 100.0));

            //Ventana
            plnLinea5.Points.Add(new Point(320.0, 130.0));
            plnLinea5.Points.Add(new Point(320.0, 160.0));
            plnLinea5.Points.Add(new Point(360.0, 160.0));
            plnLinea5.Points.Add(new Point(360.0, 130.0));
            plnLinea5.Points.Add(new Point(320.0, 130.0));
            plnLinea6.Points.Add(new Point(340.0, 130.0));
            plnLinea6.Points.Add(new Point(340.0, 160.0));
            plnLinea7.Points.Add(new Point(320.0, 145.0));
            plnLinea7.Points.Add(new Point(360.0, 145.0));

            //Arbol
            plnLinea8.Points.Add(new Point(500.0, 225.0));
            plnLinea8.Points.Add(new Point(500.0, 125.0));
            plnLinea8.Points.Add(new Point(450.0, 85.0));
            plnLinea8.Points.Add(new Point(530.0, 35.0));
            plnLinea8.Points.Add(new Point(600.0, 85.0));
            plnLinea8.Points.Add(new Point(530.0, 125.0));
            plnLinea8.Points.Add(new Point(530.0, 225.0));
        }
    }
}
