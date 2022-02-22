using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSales.Repository.Entity;

namespace UniSales.Repository
{
    public interface ICategoryRepository {
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);
        Category Get(int id);
        List<Category> GetCategorys();
    }
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public void Create(Category category)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd =
                new SqlCommand("Insert into Category values (@Name,@Description)", con);
            cmd.Parameters.AddWithValue("Name", category.Name);
            cmd.Parameters.AddWithValue("Description", category.Description);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd =
                new SqlCommand("Delete from Category Where Id = @Id", con);
            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Category Get(int id)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * from Category where Id = @Id", con);
            cmd.Parameters.AddWithValue("Id", id);

            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category category = new Category()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                };
                return category;
            }
            con.Close();
            return null;
        }

        public List<Category> GetCategories()
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("Select * from Category", con);
            List<Category> categories = new List<Category>();

            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category cate = new Category()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                };
                categories.Add(cate);
            }
            con.Close();
            return categories;
        }

        public List<Category> GetCategorys()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd =
                new SqlCommand("Update Category Set Name = @Name , Description = @Description Where Id = @Id", con);
            cmd.Parameters.AddWithValue("Name", category.Name);
            cmd.Parameters.AddWithValue("Description", category.Description);
            cmd.Parameters.AddWithValue("Id", category.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
