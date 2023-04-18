using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class TicketService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;
        public int InsertTicket()
        {
            return 0;
        }

        public int UpdateTicket()
        {
            return 0;
        }

        public int DeleteTicket()
        {
            return 0;
        }

        public List<Ticket> FindAll()
        {
            return new List<Ticket>();
        }
    }
}
