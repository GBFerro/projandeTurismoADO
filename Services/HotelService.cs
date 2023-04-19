using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class HotelService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public HotelService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public Hotel InsertHotel(Hotel hotel)
        {
            try
            {
                SqlCommand commandInsert = new SqlCommand(Hotel.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", hotel.Name));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", hotel.RegisterDate));
                commandInsert.Parameters.Add(new SqlParameter("@Value", hotel.Value));
                commandInsert.Parameters.Add(new SqlParameter("@IdAddress", hotel.Address.Id));

                int id = (int) commandInsert.ExecuteScalar();
                hotel.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return hotel;
        }

        public int UpdateHotel()
        {
            return 0;
        }

        public int DeleteHotel()
        {
            return 0;
        }

        public List<Hotel> FindAll()
        {
            return new List<Hotel>();
        }
    }
}
