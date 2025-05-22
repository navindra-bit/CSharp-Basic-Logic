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
    }
}
