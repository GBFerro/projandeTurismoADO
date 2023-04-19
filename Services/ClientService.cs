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

        public ClientService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public Client InsertClient(Client client)
        {
            int id = 0;
            try
            {
                SqlCommand commandInsert = new SqlCommand(Client.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", client.Name));
                commandInsert.Parameters.Add(new SqlParameter("@Phone", client.Phone));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", client.RegisterDate));
                commandInsert.Parameters.Add(new SqlParameter("@IdAddress", client.Address.Id));

                id = (int) commandInsert.ExecuteScalar();
                client.Address.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return client;
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
