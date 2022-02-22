using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSales.Repository.Entity;

namespace UniSales.Repository
{
    public interface IOrderRepository
    {
        void Create(Orders orders);
        void Update(int id, Orders orders);
        void Delete(int id);
        Orders Get(int id);
        List<Orders> GetOrders();
    }
    public class OrderRepository : BaseRepository ,IOrderRepository
    {
        public OrderRepository() { 
        
        }
        public void Create(Orders orders)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Insert into [Order] values (@CustomerName, @Address, @CreatedDate, @Status)", con);
            cmd.Parameters.AddWithValue("CustomerName", orders.CustomerName);
            cmd.Parameters.AddWithValue("Address", orders.Address);
            cmd.Parameters.AddWithValue("CreatedDate", orders.CreateDate);
            cmd.Parameters.AddWithValue("Status", orders.Status);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("SET XACT_ABORT ON " +
                "BEGIN TRAN " +
                "DELETE FROM OrderDetail WHERE OrderId = @OrderId " +
                "DELETE FROM [Order] WHERE Id = @Id " +
                "COMMIT", con);
            cmd.Parameters.AddWithValue("OrderId", id);
            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Orders Get(int id)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * From [Order] Where Id = @Id ", con);
            cmd.Parameters.AddWithValue("Id", id);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Orders order = new Orders()
                {
                    Id = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    Address = reader.GetString(2),
                    CreateDate = reader.GetString(3),
                    Status = reader.GetInt32(4)
                };
                return order;
            }
            con.Close();
            return null;
        }

        public List<Orders> GetOrders()
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * From [Order] ",con);
            List<Orders> orders = new List<Orders>();

            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Orders order = new Orders()
                {
                    Id = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    Address = reader.GetString(2),
                    CreateDate = reader.GetString(3),
                    Status = reader.GetInt32(4)
                };
               
                orders.Add(order);
            }
            con.Close();
            return orders;
        }

        public void Update(int id, Orders orders)
        {
            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";*/

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Update [Order] set CustomerName = @CustomerName, Address = @Address, CreatedDate = @CreatedDate, Status = @Status Where Id = @Id", con);

            cmd.Parameters.AddWithValue("CustomerName", orders.CustomerName);
            cmd.Parameters.AddWithValue("Address", orders.Address);
            cmd.Parameters.AddWithValue("CreatedDate", orders.CreateDate);
            cmd.Parameters.AddWithValue("Status", orders.Status);
            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
