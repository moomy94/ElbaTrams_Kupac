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
    /// Interaction logic for ToplaPica.xaml
    /// </summary>
    public partial class ToplaPica : Page
    {
        public ToplaPica()
        {
            InitializeComponent();
            List<CjenikToploPice> items = new List<CjenikToploPice>();
            items.Add(new CjenikToploPice() { Drink = "Kava", Price = 8 });
            items.Add(new CjenikToploPice() { Drink = "Nescaffe", Price = 12 });
            items.Add(new CjenikToploPice() { Drink = "Čaj", Price = 10 });
            toplaPicaCjenik.ItemsSource = items;
        }
        public class CjenikToploPice
        {
            public string Drink { get; set; }

            public int Price { get; set; }

        }
    }
}
