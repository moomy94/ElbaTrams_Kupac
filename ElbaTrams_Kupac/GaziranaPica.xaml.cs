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

namespace ElbaTrams_Kupac
{
    /// <summary>
    /// Interaction logic for GaziranaPica.xaml
    /// </summary>
    public partial class GaziranaPica : Page
    {
        public GaziranaPica()
        {
            InitializeComponent();
            List<CjenikGazirano> items = new List<CjenikGazirano>();
            items.Add(new CjenikGazirano() { Drink = "Coca Cola", Price = 15 });
            items.Add(new CjenikGazirano() { Drink = "Fanta", Price = 15 });
            items.Add(new CjenikGazirano() { Drink = "Sprite", Price = 15 });
            gaziranaCjenik.ItemsSource = items;
        }
        public class CjenikGazirano
        {
            public string Drink { get; set; }

            public int Price { get; set; }

        }
    }
}
