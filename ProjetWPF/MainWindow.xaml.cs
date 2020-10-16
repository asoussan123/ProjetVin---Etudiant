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
using ProjetMetier;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionnaireDeCaves gst;


        public MainWindow()
        {
            InitializeComponent();
        }

        List<GestionnaireDeCaves> lesCaves;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // A vous de jouer
            lesCaves = new List<GestionnaireDeCaves>();
            lesCaves.Add(CaveSIO1); lesCaves.Add(CaveSIO2); lesCaves.Add(CaveSIO3);
            lvCaves.ItemsSource = lesCaves;
        }

        private void lvCaves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // A vous de jouer
            lvBouteilles.ItemsSource = (lvCaves.SelectedItem as GestionnaireDeCaves).LesCaves;
        }

        private void lvBouteilles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // A vous de jouer
            if (lvBouteilles.SelectedItem != null)
            {
                txtMillesime.Text = (lvBouteilles.SelectedItem as Vin).MillesimeVin.ToString();
                txtNomCepage.Text = (lvBouteilles.SelectedItem as Cepage).NomCepage.ToString();
                txtCouleur.Text = (lvBouteilles.SelectedItem as Vin).LaCouleur.ToString();
                txtPrix.Text = (lvBouteilles.SelectedItem as Vin).PrixDuVin.ToString();
            }
        }
    }
}
