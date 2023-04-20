using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class HotelController
    {
        private HotelService _hotelService;
        private AddressService _addressService;
        private CityService _cityService;
        public HotelController()
        {
            _addressService = new AddressService();
            _cityService = new CityService();
            _hotelService = new HotelService();
        }

        public bool InsertHotel(Hotel hotel)
        {
            bool status = false;

            try
            {
                //_cityService.InsertCity(hotel.Address.City);
                //_addressService.InsertAddress(hotel.Address);
                new AddressController().InsertAddress(hotel.Address);

                _hotelService.InsertHotel(hotel);

                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
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
            return _hotelService.FindAll() ;
        }
    }
}
