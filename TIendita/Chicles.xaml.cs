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
    /// Lógica de interacción para Chicles.xaml
    /// </summary>
    public partial class Chicles : UserControl
    {
        public Chicles()
        {
            InitializeComponent();
        }

        private void CbChocolate_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtMarca.Text == "" || txtCosto.Text == "" || txtExportacion.Text == "" || txtVenta.Text == "" || txtCalidad.Text == "" || txtConvenio.Text == "")
            {
                lblAdvertencia.Visibility = Visibility.Visible;
            }
            else
            {
                grdChicles.Children.Clear();
                txtMarca.Visibility = Visibility.Hidden;
                txtCosto.Visibility = Visibility.Hidden;
                txtExportacion.Visibility = Visibility.Hidden;
                txtVenta.Visibility = Visibility.Hidden;
                txtCalidad.Visibility = Visibility.Hidden;
                txtConvenio.Visibility = Visibility.Hidden;


            }
            btnCancelar.Visibility = Visibility.Visible;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdChicles.Children.Clear();
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
        }

        private void TxtMarca_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtCosto_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtExportacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtVenta_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtCalidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtConvenio_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblAdvertencia.Visibility = Visibility.Hidden;
        }
    }
}
