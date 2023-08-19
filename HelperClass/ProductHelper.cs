using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DataAccessLayer;

namespace HelperClass
{
    public class ProductHelper
    {
        public List<Products> ShowProductList()
        {
            ProductDal dal = new ProductDal();
            List<Products> prolist= new List<Products>();
            prolist = dal.GetProducts();
            return prolist;

        }
    }
}
