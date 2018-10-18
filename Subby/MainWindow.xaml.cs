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
            h.DateOfBirth = DateTime.Now;

            SuperHero h2 = new SuperHero("George", "Smith");
            h2.DateOfBirth = DateTime.Now.AddYears(10);

            Universe.Inhabitants.Add(h);
            Universe.Inhabitants.Add(h2);

          

            SubForm sub = new SubForm();
            sub.ShowDialog();
            //MainWindow m = new MainWindow();
            //m.Show();


        }
    }
}
