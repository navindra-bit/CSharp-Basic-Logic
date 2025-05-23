using System.Data;
using UserReg.Data.Helper_Class;

namespace UserReg.Data
{
    public class UseData : DataConnect
    {
        public int inserData(string name, string age)
        {
            string query = "insert into uservalues(name,age) values (@name,@age)";

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@name", name);
            data.Add("@age", age);

            return datainsert(query, data);
        }


        public DataSet GetDataValue()
        {
            string query = "select * from uservalues";
            return GetValues(query);

        }

        public int UpdateNewData(string name, string age,string userid)
        {
            string query = "update uservalues set name = @name , age = @age Where userid =@userid";

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@name", name);
            data.Add("@age", age);
            data.Add("@userid" , userid);  
            return UpdateValues(query, data);
        }
    }
}
