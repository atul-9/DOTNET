using System;
using System.Collections.Generic;
using BusinessLogicLayer;
using HelperClass;
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
            ProductHelper ph=new ProductHelper();

            try
            {
                Console.WriteLine("Enter 1 to Show the List: ");
                int userchoic=Convert.ToInt32(Console.ReadLine());
                switch(userchoic) {

                    case 1:
                        List<Products> prolist = ph.ShowProductList();
                        foreach( var item in prolist)
                        {
                            Console.WriteLine(item.ProductId+" "+item.ProductName+" "+item.ProductPrice);
                        }
                        break;

                
                }
              
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                
            }
            Console.Read();   

        }
    }
}
