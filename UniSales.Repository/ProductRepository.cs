using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSales.Repository.Entity;

namespace UniSales.Repository
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(int id, Product product);
        void Delete(int id);
        Product Get(int id);
        List<Product> GetProducts();
    }


    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository()
        {

        }

        public void Create(Product product)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = 
                new SqlCommand("Insert into Product values (@Name,@Price,@Description,@Status,@CatId)", con);
            cmd.Parameters.AddWithValue("Name", product.Name);
            cmd.Parameters.AddWithValue("Price", product.Price);
            cmd.Parameters.AddWithValue("Description", product.Description);
            cmd.Parameters.AddWithValue("Status", product.Status);
            cmd.Parameters.AddWithValue("CatId", product.CatId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete (int Id)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd =
                new SqlCommand("SET XACT_ABORT ON " +
                "BEGIN TRAN " +
                "DELETE FROM OrderDetail WHERE ProductId = @ProductId " +
                "DELETE FROM Product WHERE Id = @Id " +
                "COMMIT", con);
            cmd.Parameters.AddWithValue("ProductId", Id);
            cmd.Parameters.AddWithValue("Id", Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(int id, Product newproduct)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();

            SqlCommand cmd =
                    new SqlCommand("Update Product set Name = @Name, Price = @Price, Description = @Description," +
                    " Status = @Status, CatId = @CatId Where Id = @Id", con);
            cmd.Parameters.AddWithValue("Name", newproduct.Name);
            cmd.Parameters.AddWithValue("Price", newproduct.Price);
            cmd.Parameters.AddWithValue("Description", newproduct.Description);
            cmd.Parameters.AddWithValue("Status", newproduct.Status);
            cmd.Parameters.AddWithValue("CatId", newproduct.CatId);
            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Product Get (int Id)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * from Product where Id = @Id", con);
            cmd.Parameters.AddWithValue("Id", Id);

            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetInt32(2),
                    Description = reader.GetString(3),
                    Status = reader.GetInt32(4),
                    CatId = reader.GetInt32(5)
                };
                return product;
            }
            con.Close();
            return null;
        }


        public List<Product> GetProducts()
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * from Product", con);
            List<Product> products = new List<Product>();

            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetInt32(2),
                    Description = reader.GetString(3),
                    Status = reader.GetInt32(4),
                    CatId = reader.GetInt32(5)
                };
                products.Add(product);
            }
            con.Close();
            return products;
        }
    }
}
