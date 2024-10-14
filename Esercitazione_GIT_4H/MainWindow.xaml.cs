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
    CD c;
    List brani = new List<Brano>();
    
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
            brani.add(b);
        }

        private void btnDatiCD_Click(object sender, RoutedEventArgs e)
        {
            lbl_Dati_Cd.Content = b.toString();
        }

        private void btnDurata_Click(object sender, RoutedEventArgs e)
        {
            lblDurata.Content=b.shortSong(int.Parse(txtInsDurata.Text));
        }

        private void btnCreaCD_Click(object sender, RoutedEventArgs e)
        {
            c = new CD(txtTitoloCD.Text, txtAutoreCD.Text, brani);
        }

        private void btnCD_ToString_Click(object sender, RoutedEventArgs e)
        {
            lblCanzoniCD.Content=c.toString();
        }

        private void btnDurata1_Click(object sender, RoutedEventArgs e)
        {
            lblDurata1.Content = c.Durata();
        }
    }
}