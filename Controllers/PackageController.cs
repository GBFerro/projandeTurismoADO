using Models;
using Services;

namespace Controllers
{
    public class PackageController
    {
        //private TicketService _ticketService;
        //private AddressService _addressService;
        //private CityService _cityService;
        //private ClientService _clientService;
        //private HotelService _hotelService;
        private PackageService _packageService;

        public PackageController()
        {
            //_cityService = new CityService();
            //_ticketService = new TicketService();
            //_addressService = new AddressService();
            //_hotelService = new HotelService();
            //_clientService = new ClientService();
            _packageService = new PackageService();
        }
        public bool InsertPackage(Package package)
        {
            bool status = false;

            try
            {
                //_cityService.InsertCity(package.Hotel.Address.City);
                //_addressService.InsertAddress(package.Hotel.Address);
                //_hotelService.InsertHotel(package.Hotel);
                new HotelController().InsertHotel(package.Hotel);

                //_cityService.InsertCity(package.Client.Address.City);
                //_addressService.InsertAddress(package.Client.Address);
                //_clientService.InsertClient(package.Client);
                new ClientController().InsertClient(package.Client);

                //_cityService.InsertCity(package.Ticket.Departure.City);
                //_cityService.InsertCity(package.Ticket.Arrival.City);
                //_addressService.InsertAddress(package.Ticket.Departure);
                //_addressService.InsertAddress(package.Ticket.Arrival);
                //_ticketService.InsertTicket(package.Ticket);
                new TicketController().InsertTicket(package.Ticket);

                _packageService.InsertPackage(package);

                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
        }

        public int UpdatePackage()
        {
            return 0;
        }

        public int DeletePackage()
        {
            return 0;
        }

        public List<Package> FindAll()
        {
            return _packageService.FindAll();
        }
    }
}