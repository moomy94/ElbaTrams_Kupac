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
    /// Interaction logic for AlkoholnaPica.xaml
    /// </summary>
    public partial class AlkoholnaPica : Page
    {
        public AlkoholnaPica()
        {
            InitializeComponent();
            List<CjenikAlkohol> items = new List<CjenikAlkohol>();
            items.Add(new CjenikAlkohol() { Drink = "Karlovačko", Price = 15 });
            items.Add(new CjenikAlkohol() { Drink = "Ožujsko", Price = 15 });
            items.Add(new CjenikAlkohol() { Drink = "Graševina", Price = 20 });
            alkoholCjenik.ItemsSource = items;
        }
        public class CjenikAlkohol
        {
            public string Drink { get; set; }

            public int Price { get; set; }

        }
    }
}
