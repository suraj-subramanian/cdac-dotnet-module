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

namespace InterestCalculatorApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int principal = Convert.ToInt32(txtPrincipal.Text);
            int rate = Convert.ToInt32(txtRate.Text);
            int term = Convert.ToInt32(txtTerm.Text);
          
            if (radioSimple.IsChecked == true)
            {
                int newAmount = principal + ((principal * rate * term) / 100);
                lblAmount.Content ="Amount : "+newAmount;
            }
        }
    }
}
