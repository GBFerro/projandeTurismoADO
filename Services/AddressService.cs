using System.Data.SqlClient;
using Models;

namespace Services
{
    public class AddressService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public AddressService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public Address InsertAddress(Address address)
        {
            int id = 0;
            try
            {
                SqlCommand commandInsert = new SqlCommand(Address.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Street", address.Street));
                commandInsert.Parameters.Add(new SqlParameter("@Number", address.Number));
                commandInsert.Parameters.Add(new SqlParameter("@District", address.District));
                commandInsert.Parameters.Add(new SqlParameter("@ZipCode", address.ZipCode));
                commandInsert.Parameters.Add(new SqlParameter("@Complement", address.Complement));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", address.RegisterDate));
                commandInsert.Parameters.Add(new SqlParameter("@IdCity", address.City.Id));

                id = (int)commandInsert.ExecuteScalar();
                address.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return address;
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
            List<Address> addresses = new List<Address>();

            SqlCommand commandSelect = new SqlCommand(Address.GETALL, conn);

            SqlDataReader reader = commandSelect.ExecuteReader();

            while (reader.Read())
            {
                Address address = new Address();

                address.Id = (int)reader["Id"];
                address.Street = (string)reader["Street"];
                address.Number = (int)reader["Number"];
                address.District = (string)reader["District"];
                address.ZipCode = (string)reader["ZipCode"];
                address.Complement = (string)reader["Complement"];
                address.City = new City() 
                { 
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    RegisterDate = (DateTime)reader["RegisterDate"]
                };
                address.RegisterDate = (DateTime)reader["RegisterDate"];

                addresses.Add(address);
            }

            return addresses;
        }
    }
}