﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainButton.Visibility = Visibility.Visible;
        }

        private void Screensaver(object sender, EventArgs e)
        {
            Panel.SetZIndex(MainButton, -1);
        }
        private void ToplaPica(object sender, EventArgs e)
        {
            prikazMenija.Content = new ToplaPica();
            Panel.SetZIndex(prikazMenija, 1);
        }

        private void GaziranaPica(object sender, EventArgs e)
        {
            prikazMenija.Content = new GaziranaPica();
            Panel.SetZIndex(prikazMenija, 1);
        }

        private void AlkoholnaPica(object sender, EventArgs e)
        {
            prikazMenija.Content = new AlkoholnaPica();
            Panel.SetZIndex(prikazMenija, 1);
        }

        private void NegaziranaPica(object sender, EventArgs e)
        {
            prikazMenija.Content = new NegaziranaPica();
            Panel.SetZIndex(prikazMenija, 1);
        }

        private void BackBotun(object sender, EventArgs e)
        {
            Panel.SetZIndex(prikazMenija, -1);
        }
    }
}
