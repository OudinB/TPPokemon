using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private BusinessManager BManager;

        private void BConnecter_Click(object sender, RoutedEventArgs e)
        {
            //co sans identifiant pour le moment
            //if (BManager.CheckConnexionUser(log.Text.ToString(), pass.Password))
                Menu win = new Menu();
                win.Show();
                this.Close();
        }
    }
}
