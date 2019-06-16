using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace StudentWebService
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetStudents()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Workspace\\dotnet projects\\StudentWebService\\StudentEmail.mdf'; Integrated Security = True; Connect Timeout = 30";
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Students";

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Studs");



                return ds;
            }
        }

        [WebMethod]
        public void UpdateChangesToDb(DataSet dataSet)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Workspace\\dotnet projects\\StudentWebService\\StudentEmail.mdf'; Integrated Security = True; Connect Timeout = 30";

            connection.Open();


            //Update command
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = connection;
            updateCommand.CommandType = CommandType.Text;
            updateCommand.CommandText = "update Students set Name=@Name,EmailId=@EmailId where ID=@ID";

            updateCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Name",
                SourceColumn = "Name",
                SourceVersion = DataRowVersion.Current
            });
            updateCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@EmailId",
                SourceColumn = "EmailId",
                SourceVersion = DataRowVersion.Current
            });
            updateCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@ID",
                SourceColumn = "ID",
                SourceVersion = DataRowVersion.Original
            });

            dataAdapter.UpdateCommand = updateCommand;


            //Insert Command
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.CommandText = "InsertProc";

            insertCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Name",
                SourceColumn = "Name",
                SourceVersion = DataRowVersion.Current
            });
            insertCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@EmailId",
                SourceColumn= "EmailId",
                SourceVersion =DataRowVersion.Current
            });
            insertCommand.Parameters.Add(new SqlParameter
            {
                ParameterName="@ID",
                SourceColumn="ID",
                SourceVersion=DataRowVersion.Current
            });

            dataAdapter.InsertCommand = insertCommand;


            //Delete Command
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = connection;
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.CommandText = "DeleteProc";

            //deleteCommand.Parameters.Add(new SqlParameter
            //{
            //    ParameterName = "@Name",
            //    SourceColumn = "Name",
            //    SourceVersion = DataRowVersion.Current
            //});
            //deleteCommand.Parameters.Add(new SqlParameter
            //{
            //    ParameterName = "@EmailId",
            //    SourceColumn = "EmailId",
            //    SourceVersion = DataRowVersion.Current
            //});
            deleteCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@ID",
                SourceColumn = "ID",
                SourceVersion = DataRowVersion.Original
            });

            dataAdapter.DeleteCommand = deleteCommand;


            //update data
            dataAdapter.Update(dataSet,"Studs");
            
        }

    }
}
