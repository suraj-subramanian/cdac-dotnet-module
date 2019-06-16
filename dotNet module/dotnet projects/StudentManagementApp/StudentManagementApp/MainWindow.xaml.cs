using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace StudentManagementApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection connection;
            
    

        public MainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=surajdb;Integrated Security=True;";
        }



        private void BtnConnectDb_Click(object sender, RoutedEventArgs e)
        {
            if (IsServerConnected())
            {
                statusLight.Fill= Brushes.Green;
            }
            else
            {
                statusLight.Fill = Brushes.Red;
            }
            connection.Close();
        }

        private void BtnInsertRecord_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Students values(" + txtRollNo.Text + ",'" + txtName.Text + "'," + txtMarks.Text + ");";

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public bool IsServerConnected()
        {
            using (var l_oConnection = new SqlConnection(connection.ConnectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
