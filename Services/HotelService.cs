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
        public int InsertHotel()
        {
            return 0;
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
