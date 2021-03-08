using System.Configuration;
using System.Data.SqlClient;

namespace ScoopenAPI.DAL
{
    public class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ScoopenDB"].ConnectionString;
            }
        }

        public static SqlConnection SqlConnectionObject
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }
    }
}
