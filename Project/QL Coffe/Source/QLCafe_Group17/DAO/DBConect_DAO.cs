using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DAO
{
    public class DBConect_DAO
    {
        //lớp conection để kết nối chương trình với sql
        private static DBConect_DAO instrance;
        
        public static DBConect_DAO Instrance
        {
            get
            {
                if (instrance == null)
                    instrance = new DBConect_DAO();
                return instrance;
            }

            private set
            {
                DBConect_DAO.instrance = value;
            }
        }

        public static DataTable excutequery { get; internal set; }

        private DBConect_DAO() {
            read();
        }
        //chuỗi kết nối sql

        //private string conectstr;
        private string ConnectionSTR;
        //string str1= "Data Source=";
        //string str2= ";Initial Catalog=QuanLyCafe;Integrated Security=True";
        //private string ConnectionSTR = @"Data Source=DESKTOP-NFV7LEP;Initial Catalog=QuanLyCafe;Integrated Security=True";


        public void read()
        {
            FileStream fs = new FileStream("Conectstring.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            ConnectionSTR = rd.ReadLine();
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
           
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối sql
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    //kiểm tra câu lệnh truy vấn và các tham số truyền vào
                    string[] listPara = query.Split(' ');// cắt chuỗi để lấy các tham số
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))//kiểm tra phần tử nào trong mảng có tý tự @ trước.
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);//add vào mảng các tham số
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);//tạo adapter sql

                adapter.Fill(data);//đổ dữ liệu vào biến data.

                connection.Close();//đóng kết nối
            }

            return data;// trả về kết quả cho hàm
        }


        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối với sql
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
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
        }
        public object ExecuteSalar(string query, object[] parameter = null)
        {
            object ob = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
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

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ob = command.ExecuteNonQuery();
                connection.Close();
            }

            return ob;// trả về số dòng đc thực thi
            //sd:insert, update, delete
        }

    }
}
