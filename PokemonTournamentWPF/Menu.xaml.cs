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
using System.Windows.Shapes;

using BusinessLayer;
using EntitiesLayer;
using System.Xml.Serialization;
using System.IO;

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public BusinessManager BManager;
        public Menu()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private void DDeconnection_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Pokemons.IsSelected)
            {
                ListViewPokemon.ItemsSource = BManager.getPokemon();
                addPokemon.Visibility = Visibility.Visible;
                Supprimer.Visibility = Visibility.Visible;
                Exporter.Visibility = Visibility.Visible;
            }
            else
            {
                addPokemon.Visibility = Visibility.Collapsed;
                Supprimer.Visibility = Visibility.Collapsed;
                Exporter.Visibility = Visibility.Collapsed;
            }


            if (Stades.IsSelected)
                ListViewStades.ItemsSource = BManager.getStade();

            if (Matchs.IsSelected)
                ListViewMatchs.ItemsSource = BManager.getMatch();

            if (Tournois.IsSelected)
                ListViewTournois.ItemsSource = BManager.getTournoi();
        }

        private void addPokemon_Click(object sender, RoutedEventArgs e)
        {
            AddPokemon win = new AddPokemon();
            win.DataContext = ListViewPokemon;
            win.Show();
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewPokemon.SelectedItem != null)
            {
                if (MessageBox.Show("Confirmer la suppression ?", "Confirmer", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    foreach (Pokemon p in ListViewPokemon.SelectedItems)
                    {
                        BManager.getPokemon().Remove(p);
                    }

                ListViewPokemon.ItemsSource = null;
                ListViewPokemon.ItemsSource = BManager.getPokemon();
            }
        }

        private void Exporter_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Pokemons";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                String filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>));
                using (var stream = File.OpenWrite(filename))
                {
                    serializer.Serialize(stream, BManager.getPokemon());
                }
            }

        }

        private void Importer_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Pokemons";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents |*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                String filename = dlg.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>));
                using (var stream = File.OpenRead(filename))
                {
                    var item = (List<Pokemon>)(serializer.Deserialize(stream));
                    BManager.getPokemon().Clear();
                    BManager.getPokemon().AddRange(item);
                }
                ListViewPokemon.ItemsSource = null;
                ListViewPokemon.ItemsSource = BManager.getPokemon();
            }
        }
        //fonction ajoutée , reference dans la balise Liste view ligne 42 dans Menu.xaml
        private void Detail_Pokemon_Click(object sender, EventArgs e)
        {
            try
            {
                EntitiesLayer.Pokemon item =(Pokemon)ListViewPokemon.SelectedItems[0];
                PokeWindow win = new PokeWindow(item);
                win.Show();
               // this.Close();
            }
            catch { }
        }
        private void Detail_Tournoi_Click(object sender, EventArgs e)
        {
            try
            {
                EntitiesLayer.Tournoi item = (Tournoi)ListViewTournois.SelectedItems[0];
                TournoiWindow win = new TournoiWindow(item);
                win.Show();
                this.Close();
            }
            catch { }
        }

    }

}
