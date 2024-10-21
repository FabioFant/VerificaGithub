// Commento

using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppBiblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Biblioteca biblioteca = new Biblioteca("", "", "");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl_nome.Content = nome_biblioteca.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbl_apertura.Content = orario_apertura.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lbl_nome.Content = orario_chiusura.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // N_libri
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Titolo
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            // Autore
        }
    }
}
