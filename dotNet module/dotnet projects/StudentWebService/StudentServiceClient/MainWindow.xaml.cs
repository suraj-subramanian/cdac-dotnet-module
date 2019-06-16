using System;
using System.Collections.Generic;
using System.Data;
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

namespace StudentServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private localhost.StudentService studentService;
        private DataSet dataSet;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            studentService = new localhost.StudentService();
            dataSet = studentService.GetStudents();
            dataGrid.ItemsSource= dataSet.Tables["Studs"].DefaultView;
        }

        private void BtnUpdateToDb_Click(object sender, RoutedEventArgs e)
        {
            //localhost.StudentService studentService = new localhost.StudentService();
            studentService.UpdateChangesToDb(dataSet);
        }
    }
}
