using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class ClientService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;
        public int InsertClient()
        {
            return 0;
        }

        public int UpdateClient()
        {
            return 0;
        }

        public int DeleteClient()
        {
            return 0;
        }

        public List<Client> FindAll()
        {
            return new List<Client>();
        }
    }
}
