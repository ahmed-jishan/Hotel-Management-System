using System;
using System.Data;
using System.Data.SqlClient;

namespace Last_Project
{
    class DBAccess
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void connection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DC8UVOD;Initial Catalog=LProject;Integrated Security=True");
            con.Open();
        }
        public static string connectionDatabase()
        {
            return "Data Source=DESKTOP-DC8UVOD;Initial Catalog=LProject;Integrated Security=True";

        }

        public void dataSend(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                var flag = cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception ex)
            {

                pkk = ex.Message;
            }
            con.Close();
        }
        public void dataGet(string SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con);
            }
            catch (Exception)
            {

            }

        }
    }
}
