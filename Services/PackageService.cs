using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class PackageService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public PackageService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public Package InsertPackage(Package package)
        {
            try
            {
                SqlCommand commandInsert = new SqlCommand(Package.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@IdHotel", package.Hotel.Id));
                commandInsert.Parameters.Add(new SqlParameter("@IdTicket", package.Ticket.Id));
                commandInsert.Parameters.Add(new SqlParameter("@IdClient", package.Client.Id));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", package.RegisterDate));
                commandInsert.Parameters.Add(new SqlParameter("@Value", package.Value));

                int id = (int)commandInsert.ExecuteScalar();
                package.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return package;
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
