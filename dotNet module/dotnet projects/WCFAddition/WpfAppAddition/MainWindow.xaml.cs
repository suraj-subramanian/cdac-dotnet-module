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

namespace WpfAppAddition
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

        private void BtnGetData_Click(object sender, RoutedEventArgs e)
        {
            AdditionService.IService service = new AdditionService.ServiceClient();
            lblOutput.Content=service.GetData(Convert.ToInt32(txtInput.Text));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AdditionService.ServiceClient service = new AdditionService.ServiceClient();
            lblAddResult.Content = Convert.ToString(service.Add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)));
        }
    }
}
