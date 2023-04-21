using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class TicketController
    {
        public readonly static string INSERT = "insert into Ticket (Departure, Arrival, RegisterDate, Value) " +
            "values (@Departure, @Arrival, @RegisterDate, @Value); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "Select ticket.[Id] as TicketId, addressDeparture.[Id] as IdAddressDeparture, " +
            "addressDeparture.[Street] as StreetAddressDeparture, addressDeparture.[Number] as NumberAddressDeparture, " +
            "addressDeparture.[District] as DistrictAddressDeparture, addressDeparture.[ZipCode] as ZipAddressDeparture, " +
            "addressDeparture.[Complement] as ComplementAddressDeparture, cityDeparture.[Id] as IdCityDeparture, " +
            "cityDeparture.[Name] as NameCityDeparture, cityDeparture.[RegisterDate] as RegisterCityDeparture, " +
            "addressDeparture.[RegisterDate] as RegisterAddressDeparture, " +
            "addressArrival.[Id] as IdAddressArrival, addressArrival.[Street] as StreetAddressArrival, addressArrival.[Number] as NumberAddressArrival, " +
            "addressArrival.[District] as DistrictAddressArrival, addressArrival.[ZipCode] as ZipAddressArrival, " +
            "addressArrival.[Complement] as ComplementAddressArrival, cityArrival.[Id] as IdCityArrival, cityArrival.[Name] as NameCityArrival, " +
            "cityArrival.[RegisterDate] as RegisterCityArrival, addressArrival.[RegisterDate] as RegisterAddressArrival, " +
            "ticket.[Value] as valueTicket, ticket.[RegisterDate] as registerTicket " +
            "from[Ticket] ticket join[Address] addressArrival on ticket.[Arrival] = addressArrival.[Id] " +
            "join[City] cityArrival on addressArrival.[IdCity] = cityArrival.[Id] " +
            "join[Address] addressDeparture on ticket.[Departure] = addressDeparture.[Id] " +
            "join[City] cityDeparture on addressDeparture.[IdCIty] = cityDeparture.[Id]";



        private TicketService _ticketService;
        //private AddressService _addressService;
        //private CityService _cityService;

        public TicketController()
        {
            //_cityService = new CityService();
            //_addressService = new AddressService();
            _ticketService = new TicketService();
        }

        public bool InsertTicket(Ticket ticket)
        {
            bool status = false;

            try
            {
                //_cityService.InsertCity(ticket.Departure.City);
                //_cityService.InsertCity(ticket.Arrival.City);
                //_addressService.InsertAddress(ticket.Departure);
                //_addressService.InsertAddress(ticket.Arrival);
                new AddressController().InsertAddress(ticket.Departure);
                new AddressController().InsertAddress(ticket.Arrival);

                _ticketService.InsertTicket(ticket, INSERT);

                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
        }

        public int UpdateTicket()
        {
            return 0;
        }

        public int DeleteTicket()
        {
            return 0;
        }

        public List<Ticket> FindAll()
        {
            return _ticketService.FindAll(GETALL);
        }
    }
}
