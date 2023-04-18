using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class PackageService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;
        public int InsertPackage()
        {
            return 0;
        }

        public int UpdatePackage()
        {
            return 0;
        }

        public int DeletePackage()
        {
            return 0;
        }

        public List<Package> FindAll()
        {
            return new List<Package>();
        }
    }
}
