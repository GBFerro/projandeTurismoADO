using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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

                id = (int)commandInsert.ExecuteScalar();
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
            List<Client> clients = new List<Client>();

            SqlCommand commandSelect = new SqlCommand(Client.GETALL, conn);

            SqlDataReader reader = commandSelect.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client();

                client.Id = (int)reader["Id"];
                client.Address = new Address()
                {
                    Id = (int)reader["Id"],
                    Street = (string)reader["Street"],
                    Number = (int)reader["Number"],
                    District = (string)reader["District"],
                    ZipCode = (string)reader["ZipCode"],
                    Complement = (string)reader["Complement"],
                    City = new City()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        RegisterDate = (DateTime)reader["RegisterDate"]
                    },
                    RegisterDate = (DateTime)reader["RegisterDate"]
                };
                client.Name = (string)reader["Name"];
                client.Phone = (string)reader["Phone"];
                client.RegisterDate = (DateTime)reader["RegisterDate"];


                clients.Add(client);
            }

            return clients;
        }
    }

}


