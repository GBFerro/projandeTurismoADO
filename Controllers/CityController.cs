using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class CityController
    {
        public readonly static string INSERT = "insert into City (Name, RegisterDate) " +
            "values (@Name, @RegisterDate); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select Id , Name, RegisterDate from City";

        public readonly static string DELETE = "delete from City where Id = @Id"; 

        private CityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }

        public bool InsertCity(City city)
        {
            bool status = false;
            try
            {
                _cityService.InsertCity(city, INSERT);
                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
        }

        public bool UpdateCity()
        {
            return true;
        }

        public bool DeleteCity(int id)
        {
            return _cityService.DeleteCity(id, DELETE);
        }

        public List<City> FindAll()
        {
            return _cityService.FindAll(GETALL);
        }
    }
}
