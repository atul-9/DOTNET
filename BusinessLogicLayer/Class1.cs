using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Products
    {
		private int _prodit;

		public int ProductId
		{
			get { return _prodit; }//sendn data to the user
            set
            {
                if (value>0) { _prodit = value; }
                else
                {
                    throw new NullReferenceException("Product id cannot be null");
                }
                
            } //to accept the data from the user

        }
		
	}
}
