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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band("jdskjfns", 1970);
            Band b2 = new Rock("asdf", 1999);
            Band b3 = new Band("help", 2000);
            Band b4 = new Band("me", 2002);
            Band b5 = new Band("the killers", 2005);
            Band b6 = new Band("coldplay", 2002);

            List<Band> allbands = new List<Band>();
            allbands.Add(b1);
            allbands.Add(b2);
            allbands.Add(b3);
            allbands.Add(b4);
            allbands.Add(b5);
            allbands.Add(b6);

            Lbox.ItemsSource = allbands.OrderBy(b => b.BandName);

            //setting contents of ComboBox
            cbxGenre.ItemsSource = new string[] { "All", "Rock", "Indie", "Pop" };
            

        }

        
    }

}

