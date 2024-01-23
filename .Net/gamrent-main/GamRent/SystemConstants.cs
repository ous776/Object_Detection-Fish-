using System.Configuration;

namespace GamRent
{
    public class SystemConstants
    {
        public static string LocalConnectionString = ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString;//"server=localhost; port=3306; database=rmDb1; user=root; password=gamfront; Persist Security Info=False; Connect Timeout=300";
    }
}
