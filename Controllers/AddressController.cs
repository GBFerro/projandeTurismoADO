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

                _addressService.InsertAddress(address);

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
            return _addressService.FindAll();
        }
    }
}
