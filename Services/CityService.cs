using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class CityService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projAndreTurismo\Database\AndreTurismo.mdf";
        readonly SqlConnection conn;

        public CityService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public City InsertCity(City city)
        {
            int id = 0;

            try
            {
                SqlCommand commandInsert = new SqlCommand(City.INSERT, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", city.Name));
                commandInsert.Parameters.Add(new SqlParameter("@RegisterDate", city.RegisterDate));
                
                id = (int)commandInsert.ExecuteScalar();
                city.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return city;
        }

        public int UpdateCity()
        {
            return 0;
        }

        public int DeleteCity()
        {
            return 0;
        }

        public List<City> FindAll()
        {
            return new List<City>();
        }
    }
}
