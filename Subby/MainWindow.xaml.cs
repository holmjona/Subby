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

namespace Subby {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnOpenWindow_Click(object sender, RoutedEventArgs e) {
            SuperHero h = new SuperHero("","");

            Universe.Inhabitants.Add(h);

          

            SubForm sub = new SubForm();
            sub.ShowDialog();
            //MainWindow m = new MainWindow();
            //m.Show();


        }
    }
}
