using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSales.Repository
{
    public class BaseRepository
    {
        protected SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-FE0PQLJ\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "lamborghini";
            builder.InitialCatalog = "Sale_Product";

            SqlConnection con = new SqlConnection(builder.ConnectionString);

            return con;
        }
    }
}
