using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class CityService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public int InsertCity()
        {
            return 0;
        }

        public int UpdateCity()
        {
            return 0;
        }

        public int DeleteCity()
        {
            return 0;
        }

        public List<City> FindAll()
        {
            return new List<City>();
        }
    }
}
