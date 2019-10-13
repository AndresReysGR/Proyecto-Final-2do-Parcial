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

namespace TIendita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
 
        /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgrgar_Click(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Clear();
            switch (cbCategorias.SelectedIndex)
            {
                case 0:
                    grdContenido.Children.Add(new Galletas());
                    break;
                case 1:
                    grdContenido.Children.Add(new Chicles());
                    break;
                case 2:
                    grdContenido.Children.Add(new Chocolates());
                    break;
                case 3:
                    grdContenido.Children.Add(new Helado());
                    break;
                case 4:
                    grdContenido.Children.Add(new Refresco());
                    break;
                case 5:
                    grdContenido.Children.Add(new Sabritas());
                    break;

                default:
                    break;
            }

           



        }

       
    }
}



           
