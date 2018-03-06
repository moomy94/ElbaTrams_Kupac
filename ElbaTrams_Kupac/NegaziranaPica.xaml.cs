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
    /// Interaction logic for NegaziranaPica.xaml
    /// </summary>
    public partial class NegaziranaPica : Page
    {
        public NegaziranaPica()
        {
            InitializeComponent();
            List<CjenikNegazirano> items = new List<CjenikNegazirano>();
            items.Add(new CjenikNegazirano() { Drink = "Ledeni čaj", Price = 15 });
            items.Add(new CjenikNegazirano() { Drink = "Juicy sokovi", Price = 10 });
            items.Add(new CjenikNegazirano() { Drink = "ljimunad", Price = 25 });
            negaziranaCjenik.ItemsSource = items;
        }
        public class CjenikNegazirano
        {
            public string Drink { get; set; }

            public int Price { get; set; }

        }
    }
}
