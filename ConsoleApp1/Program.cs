using System;
using BusinessLogicLayer;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products p= new Products();
           ConnectToDB c=new ConnectToDB();
           
//            mysql_host = "localhost"
//mysql_user = "root"
//mysql_password = "xyz"
//mysql_database = "javaproject"
            //conn = mysql.connector.connect(
            //host = MYSQL_HOST,
            //user = MYSQL_USER,
            //password = MYSQL_PASSWORD,
            //database = MYSQL_DATABASE
            //)
            try
            {
                c.Connect();
                //Console.WriteLine("Enter ProductId");
                //p.ProductId = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Product Id is Valid");
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                
            }
            Console.Read();   

        }
    }
}
