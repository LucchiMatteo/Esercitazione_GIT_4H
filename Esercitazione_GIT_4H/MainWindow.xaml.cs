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

namespace Esercitazione_GIT_4H
{
    Brano b;
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreaBrano_Click(object sender, RoutedEventArgs e)
        {
            b = new Brano(txtInstitolo.Text, txtInsAutore.Text, txtInsDurata.Text);
        }

        private void btnDatiCD_Click(object sender, RoutedEventArgs e)
        {
            lbl_Dati_Cd.Content = b.toString();
        }

        private void btnDurata_Click(object sender, RoutedEventArgs e)
        {
            lblDurata.Content=b.shortSong(int.Parse(txtInsDurata.Text));
        }
    }
}