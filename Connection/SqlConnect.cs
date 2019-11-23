using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Connection
{
    public class ConectionDB
    {
        private static string machineName = Environment.GetEnvironmentVariable("computername");

        private static string cdn = 
            "Data Source="+machineName+";" +
            "Initial Catalog=ENLACE_FE;" +
            "Persist Security Info=True;" +
            "User ID=sa;" +
            "Password=masterkey";

        private SqlConnection connect = new SqlConnection(cdn);

        public void SqlConnect()
        {
            connect.Open();
        }
        public void SqlCloseConection()
        {
            connect.Close();
        }
    }
}
