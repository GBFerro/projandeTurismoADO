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

        public TicketService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public Ticket InsertTicket(Ticket ticket)
        {
            try
            {
                SqlCommand commandInsert = new SqlCommand(Ticket.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Departure", ticket.Departure.Id));
                commandInsert.Parameters.Add(new SqlParameter("@Arrival", ticket.Arrival.Id));
                //commandInsert.Parameters.Add(new SqlParameter("@IdClient", ticket.Client.Id));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", ticket.RegisterDate));
                commandInsert.Parameters.Add(new SqlParameter("@Value", ticket.Value));

                int id = (int) commandInsert.ExecuteScalar();
                ticket.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return ticket;
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
