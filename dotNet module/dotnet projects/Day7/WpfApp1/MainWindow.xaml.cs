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

namespace WpfApp1
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

        //static bool flag = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lblTitle.Content.ToString() == "Good Morning")
            {
                lblTitle.Content = "Hello World";
            }
            else
            {
                lblTitle.Content = "Good Morning";
            }
        }

        private void BtnShowFullName_Click(object sender, RoutedEventArgs e)
        {

            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        

        }

        private void BtnClearFullName_Click(object sender, RoutedEventArgs e)
        {
            txtFullName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void TxtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }
    }
}
