using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class SQl
    {
        string connectionString = "Data Source=(LocalDb)COSMIN\\SQLEXPRESS01; Database=GestioFoods; Integrated Security= True";
        public List<Product> TakeAllProducts()
        {
            string query = "SELECT p.*, f.ingredients, b.quantity " +
                "FROM Product p" +
                " LEFT JOIN food f ON p.ProductID = f.ProductID" +
                "LEFT JOIN beverage h ON p.ProductID = b.ProductID";
            List<Product> fetchedProducts = new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = reader["Name"].ToString();
                    string type = reader["ProductType"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    
                    if (type == "Food")
                    {
                        string ingredients = reader["ingredients"].ToString();
                        string platform = reader["Platform"].ToString();
                        Food food= new Food(name, price , List<ingredients>) // !
                        fetchedProducts.Add(food);
                    }
                    else if (type == "Beverage")
                    {
                        int quantity = Convert.ToInt32(reader["quantity"]);
                        Beverage beverage = new Beverage( name, price , quantity );
                        fetchedProducts.Add(beverage);
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return fetchedProducts;
        }
    }
}
