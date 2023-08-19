using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    internal static class CommonClass
    {
        public static void Connect()
        {

            string cnstring = "server=localhost;userid=root;password=xyz;database=shopping";
            MySqlConnection cn = new MySqlConnection(cnstring);
            MySqlCommand cmd = new MySqlCommand("select * from products", cn);
            cn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[s0] + "\t" + dr[1] + "\t" + dr[2]);


            }
            cn.Close();


        }
    }
}
