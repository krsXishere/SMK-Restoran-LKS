using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heeh.models
{
    internal class Helper
    {
        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LAPTOP-N0P1C1AP;Initial Catalog=db_restoran;Integrated Security=True";
            return connection;
        }

        public DataSet getData(String query)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public void setData(String query, String message)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show(""+message+"", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataTable Login(String email, String pass)
        {
            SqlConnection connection = getConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select position, namaEmployee from MsEmployee where email='"+email+"' and pass='"+pass+"'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
