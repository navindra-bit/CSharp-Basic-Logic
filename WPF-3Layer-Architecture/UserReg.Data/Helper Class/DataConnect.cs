using Microsoft.Data.SqlClient;

namespace UserReg.Data.Helper_Class
{
    public class DataConnect
    {
       
        protected int datainsert(string querey , Dictionary<string, string> dic )
        {
            string sqlconnt = "Data Source=NAVINDRA-M\\SQLEXPRESS;Initial Catalog=uservalue;Integrated Security=True;Encrypt=False;";

            SqlConnection connection = new SqlConnection( sqlconnt );
            connection.Open();
            SqlCommand command = new SqlCommand(querey, connection);
            if (dic != null)
            {
                foreach (var para in dic)
                {
                    command.Parameters.AddWithValue(para.Key, para.Value);
                }
            }
            return command.ExecuteNonQuery();

        }
    }
}
