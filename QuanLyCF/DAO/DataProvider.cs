using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance // tao design patern singerton(tai 1 thoi diem co duy nhat 1 connection ket noi voi sql server)
        {
            get { if (instance == null) 
                      instance = new DataProvider(); 
                return DataProvider.instance; 
                }
            private set { DataProvider.instance = value; }
        }
        private DataProvider(){}

        private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyCF;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter =null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // giải phóng bộ nhớ
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // thuc thi truy vấn


                if (parameter !=null) // truyen tham so proc
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command); // trung gian thuc hiện truy vấn và lấy dữ liệu

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        
        }//tra bang du lieu

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // giải phóng bộ nhớ
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // thuc thi truy vấn


                if (parameter != null) // truyen tham so proc
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;

        } // tra ket qua so dong thanh cong

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // giải phóng bộ nhớ
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // thuc thi truy vấn


                if (parameter != null) // truyen tham so proc
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;

        } // tra ket qua dem so luong

    }
}
