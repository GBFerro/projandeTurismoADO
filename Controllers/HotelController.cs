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
        public readonly static string INSERT = "insert into Hotel (Name, IdAddress, RegisterDate, Value) " +
            "values (@Name, @IdAddress, @RegisterDate, @Value); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select hotel.[Id] as IdHotel, hotel.[Name] as NameHotel, " +
            "hotel.[Value] as ValueHotel, " +
            "address.[Id] as IdAddress, address.[Street] as StreetAddress, " +
            "address.[Number] as NumberAddress, " +
            "address.[District] as DistrictAddress, address.[ZipCode] as ZipAddress, " +
            "address.[Complement] as ComplementAddress, city.[Id] as IdCity, city.[Name] as NameCity, " +
            "city.[RegisterDate] as RegisterCity, address.[RegisterDate] as RegisterAddress, " +
            "hotel.[RegisterDate] as RegisterHotel " +
            "from [Hotel] hotel join [Address] address on hotel.[IdAddress] = address.[Id] " +
            "join [City] city on city.[Id] = address.[IdCity]";

        public readonly static string DELETE = "delete from Hotel where Id = @Id";


        private HotelService _hotelService;
        //private AddressService _addressService;
        //private CityService _cityService;
        public HotelController()
        {
            //_addressService = new AddressService();
            //_cityService = new CityService();
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

                _hotelService.InsertHotel(hotel, INSERT);

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

        public bool DeleteHotel(int id)
        {
            return _hotelService.DeleteHotel(id, DELETE);
        }

        public List<Hotel> FindAll()
        {
            return _hotelService.FindAll(GETALL) ;
        }
    }
}
