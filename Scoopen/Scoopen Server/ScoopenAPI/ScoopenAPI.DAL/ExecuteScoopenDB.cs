using System.Data;
using System.Data.SqlClient;

namespace ScoopenAPI.DAL
{
    public class ExecuteScoopenDB
    {
        public static SqlDataReader ExecuteReader(SqlConnection con, string procedureName, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(procedureName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            con.Open();

            return cmd.ExecuteReader();
        }
    }
}
