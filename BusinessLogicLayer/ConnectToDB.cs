using System;
using System.Collections.Generic;
using MySqlConnector;
namespace BusinessLogicLayer
{
    public  class ConnectToDB
    {

        public void Connect()
        {

      string cnstring="server=localhost;userid=root;password=xyz;database=shopping";
            //mysql_user = "root"
            //mysql_password = "xyz"
            //mysql_database = "javaproject"
            MySqlConnection cn = new MySqlConnection(cnstring);
            MySqlCommand cmd = new MySqlCommand("select * from products", cn);
            cn.Open();
            MySqlDataReader dr=cmd.ExecuteReader();
           while (dr.Read()) {
                Console.WriteLine(dr[0] + "\t" + dr[1] +"\t" + dr[2]);


            }
            cn.Close();
            1s
        
        }
    }
}
