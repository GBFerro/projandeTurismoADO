using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AddressController
    {
        public readonly static string INSERT = "insert into Address (Street, Number, District, ZipCode, Complement, RegisterDate, IdCity) " +
            "values (@Street, @Number, @District, @ZipCode, @Complement, @RegisterDate, @IdCity); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select a.Id as AddressId, a.Street as AddressStreet, " +
            "a.Number as AddressNumber, a.District as AddressDistrict, " +
            "a.ZipCode as AddressZip, " +
            "a.Complement as AddressComplement, c.Id as CityId, c.Name as CityName, " +
            "c.RegisterDate as CityRegister, a.RegisterDate as AddressRegister " +
            "from Address a join City c on a.IdCity = c.Id";

        private AddressService _addressService;
        //private CityService _cityService;
        public AddressController() {
            _addressService = new AddressService();
            //_cityService = new CityService();
        }  

        public bool InsertAddress(Address address)
        {
            bool status = false;
            try
            {
                new CityController().InsertCity(address.City);
                //address.City = _cityService.InsertCity(address.City);

                _addressService.InsertAddress(address, INSERT);

                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }
            return status;
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
            return _addressService.FindAll(GETALL);
        }
    }
}
