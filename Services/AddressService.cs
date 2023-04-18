using System.Data.SqlClient;
using Models;

namespace Services
{
    public class AddressService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public int InsertAddress()
        {
            return 0;
        }

        public int UpdateAddress()
        {
            return 0;
        }

        public int DeleteAddress()
        {
            return 0;
        }

        public List<Address> FindAll()
        {
            return new List<Address>();
        }
    }
}