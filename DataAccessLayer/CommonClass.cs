using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    internal class CommonClass
    {
        static string cnstring = "server=localhost;userid=root;password=xyz;database=shopping";
        static MySqlConnection cn = new MySqlConnection(cnstring);
        public static MySqlConnection Connect()
        {
            cn.Open();
            return cn;
        }

        public static void Disconnect() {
            cn.Close();   
            cn.Dispose();   
}

    }
}
