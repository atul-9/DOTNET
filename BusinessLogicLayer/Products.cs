using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using var connection = new MySqlConnection(yourConnectionString);
namespace BusinessLogicLayer
{
    public class Products
    {
		private int _prodid;

		public int ProductId
		{
			get { return _prodid; }//sendn data to the user
            set
            {
                if (value>0) { _prodid = value; }
                else
                {
                    throw new NullReferenceException("Product id cannot be null");
                }
                
            } //to accept the data from the user

        }

        private String _productName;

        public String ProductName
        {
            get { return _productName;
; }
            set { _productName = value; }
        }

        private float _price;

        public float ProductPrice
        {
            get { return _price; }
            set { _price = value; }
        }



    }
}
