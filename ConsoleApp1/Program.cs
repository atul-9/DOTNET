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

            try
            {
                c.Connect();
              
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                
            }
            Console.Read();   

        }
    }
}
