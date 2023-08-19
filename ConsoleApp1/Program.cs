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
            try
            {
                Console.WriteLine("Enter ProductId");
                p.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Id is Valid");
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                
            }
           

        }
    }
}
