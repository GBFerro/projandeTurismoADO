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
        private TicketService _ticketService;
        private AddressService _addressService;
        private CityService _cityService;

        public TicketController()
        {
            _cityService = new CityService();
            _ticketService = new TicketService();
            _addressService = new AddressService();
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

                _ticketService.InsertTicket(ticket);

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
            return new List<Ticket>();
        }
    }
}
