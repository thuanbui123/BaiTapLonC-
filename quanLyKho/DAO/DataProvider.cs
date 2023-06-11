using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKho.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectSTR = @"Data Source=DESKTOP-A5FUL33\SQLEXPRESS;DATABASE=quanLyKho;User ID=sa; password =1";

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value; 
        }

        public DataProvider() { }

        public DataTable executeQuery (string query, object[] parameter = null)
        {
            DataTable ds = new DataTable();

            SqlConnection connection = new SqlConnection(connectSTR);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string s in listPara)
                {
                    if (s.Contains('@'))
                    {
                        command.Parameters.AddWithValue(s, parameter[i]);
                        i++;
                    }
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            connection.Close();

            return ds;
        }

        public int executeNonQuery (string query, object[] parameter = null)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(connectSTR);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach(string s in listPara)
                {
                    if (s.Contains('@'))
                    {
                        command.Parameters.AddWithValue(s, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteNonQuery();

            connection.Close();

            return data;
        }

        public object executeScalar (string query, object[] parameter = null)
        {
            object data = 0;

            SqlConnection connection = new SqlConnection(connectSTR);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach(string s in listPara)
                {
                    if (s.Contains('@'))
                    {
                        command.Parameters.AddWithValue(s, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteScalar();

            connection.Close();

            return data;
        }
    }
}
