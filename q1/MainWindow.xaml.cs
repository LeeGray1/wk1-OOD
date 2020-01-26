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

namespace q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> musicBands = new List<Band>();
        List<Band> filteredMusicBands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }     



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Rock band1 = new Rock()
            {
                BandName = "AC/DC",
                yearofFormation = 1973,
                membersofBand = " Angus Young, Brian Johnson, Bon Scott"
            };

            Pop band2 = new Pop()
            {
                BandName = "Fall out boy",
                yearofFormation = 2001,
                membersofBand = "Patrick Stump, bassist Pete Wentz,Joe Trohman, Andy Hurley"
            };

            Indie band3 = new Indie()
            {
                BandName = "Sabaton",
                yearofFormation = 2000,
                membersofBand = "Johan Hegg, Par Sundstrom, Chris Rorland, Hannes dan Vahl, Tommy Johansson"
            };

            Rock band4 = new Rock()
            {
                BandName = "Queen",
                yearofFormation = 1970,
                membersofBand = "Freddie Mercury, Brian May, John Deacon, and Roger Taylor"
            };

            Indie band5 = new Indie()
            {
                BandName = "Powerwolf",
                yearofFormation = 2003,
                membersofBand = "	Matthew Greywolf, Charles Greywolf, Falk Maria Schlegel, Attila Dorn, Roel van Helden"
            };

            Pop band6 = new Pop()
            {
                BandName = "Maroon 5",
                yearofFormation = 2001,
                membersofBand = " Adam Levine, James Valentine, PJ Morton, Mickey Madden, Jesse Carmichael, Matt Flynn, Sam Farrar, Ryan Dusick"
            };

            musicBands.Add(band1);
            musicBands.Add(band2);
            musicBands.Add(band3);
            musicBands.Add(band4);
            musicBands.Add(band5);
            musicBands.Add(band6);

            Lbox.ItemsSource = musicBands;

            cbxGenre.Items.Add("All");
            cbxGenre.Items.Add("Pop");
            cbxGenre.Items.Add("Rock");
            cbxGenre.Items.Add("Indie");

        }

        public void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = Lbox.SelectedItem as Band;
            if (selectedBand != null)
            {

            }
        }

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredMusicBands.Clear();

            string selectedItem = cbxGenre.SelectedItem as string;

            switch (selectedItem)
            {
                case "All":
                    Lbox.ItemsSource = musicBands;
                    break;


                case "Rock":
                    foreach (Band b in musicBands)
                    {
                        if (b.GetType().Name == "Rock")
                        {
                            filteredMusicBands.Add(b);
                        }
                    }
                    Lbox.ItemsSource = null;
                    Lbox.ItemsSource = filteredMusicBands;
                    break;

                case "Pop":
                    foreach (Band b in musicBands)
                    {
                        if (b.GetType().Name == "Pop")
                        {
                            filteredMusicBands.Add(b);
                        }
                    }
                    Lbox.ItemsSource = null;
                    Lbox.ItemsSource = filteredMusicBands;
                    break;

                case "Indie":
                    foreach (Band b in musicBands)
                    {
                        if (b.GetType().Name == "Indie")
                        {
                            filteredMusicBands.Add(b);
                        }
                    }
                    Lbox.ItemsSource = null;
                    Lbox.ItemsSource = filteredMusicBands;
                    break;


            }
        }


    }
}

