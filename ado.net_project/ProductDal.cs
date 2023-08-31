using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net_project
{
    public class ProductDal
    {
        SqlConnection _connect = new SqlConnection(@"server=localhost\SQLEXPRESS;initial catalog=AHMET;integrated security=true");
        public List<Product> GetAll()
        {
           
            if(_connect.State == System.Data.ConnectionState.Closed)
            {
                _connect.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products",_connect);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);

            List<Product> products = new List<Product>();
            while(reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connect.Close();

            return products;

        }

        public void Add(Product product)
        {
            if (_connect.State == System.Data.ConnectionState.Closed)
            {
                _connect.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connect);
            sqlCommand.Parameters.AddWithValue("@name",product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            sqlCommand.ExecuteNonQuery();

            _connect.Close();
        }

        public void Update(Product product)
        {
            if (_connect.State == System.Data.ConnectionState.Closed)
            {
                _connect.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id)", _connect);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();

            _connect.Close();
        }


















        //public List<Product> GetAll2()
        //{
        //    SqlConnection connect = new SqlConnection(@"server=localhost\SQLEXPRESS;initial catalog=AHMET;integrated security=true");
        //    if (connect.State == System.Data.ConnectionState.Closed)
        //    {
        //        connect.Open();
        //    }
        //    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", connect);

        //    SqlDataReader reader = sqlCommand.ExecuteReader();

        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);

        //    reader.Close();
        //    connect.Close();

        //    return dataTable;

        //}


    }
}
