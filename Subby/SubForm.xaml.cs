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
using System.Windows.Shapes;

namespace Subby {
    /// <summary>
    /// Interaction logic for SubForm.xaml
    /// </summary>
    public partial class SubForm : Window {
        public SubForm() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) {
            int minAge = Universe.Inhabitants.Min(x => x.Age);
            tbxName.Text = minAge.ToString();
            //this.Close();
        }

        private void btnClose2_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
