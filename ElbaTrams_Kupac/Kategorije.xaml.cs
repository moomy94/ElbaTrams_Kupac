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
    /// Interaction logic for Kategorije.xaml
    /// </summary>
    public partial class Kategorije : Page
    {
        public Kategorije()
        {
            InitializeComponent();
        }

        private void ToplaPica(object sender, EventArgs e)
        {
            ostaliMeniji.Content = new ToplaPica();
        }
    }
}
