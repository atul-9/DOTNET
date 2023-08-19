using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BusinessLogicLayer;
namespace DataAccessLayer
{
    public class ProductDal     
    {
        public int InsertProduct(Products productData)
        {
           MySqlConnection cn= CommonClass.Connect();
            MySqlCommand cmd = new MySqlCommand("insert into products values (@productid, @productname, @price)",cn);
            cmd.Parameters.AddWithValue("@productid", productData.ProductId);
            cmd.Parameters.AddWithValue("@productname", productData.ProductName);
            cmd.Parameters.AddWithValue("@price", productData.ProductPrice);
                int numberofRow= cmd.ExecuteNonQuery();
           

            CommonClass.Disconnect();
            return numberofRow;
        }

        public List<Products> GetProducts()
        {
            MySqlConnection cn = CommonClass.Connect();
            MySqlCommand cmd = new MySqlCommand("select * from products", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Products> products = new List<Products>();
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    Products p = new Products();
                    p.ProductId = (int) dr["ProductId"];
                    p.ProductName = dr["ProductName"].ToString();
                    p.ProductPrice = Convert.ToSingle( dr["Price"]);
                    products.Add(p);

                }
            }
            CommonClass.Disconnect();
            return products;
        }
    }
}
