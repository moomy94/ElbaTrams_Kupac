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
            prikazMenija.Content = new Kategorije();
        }

        private void BackBotun(object sender, EventArgs e)
        {
            BackButton.Visibility = Visibility.Hidden;
        }

    }
}
