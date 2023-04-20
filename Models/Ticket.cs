using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
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

        public int Id { get; set; }
        public Address Arrival { get; set; }
        public Address Departure { get; set; }
        //public Client Client { get; set; }
        public decimal Value { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            //return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return $"\n\tId: {this.Id}\n\tArrival: {this.Arrival}\n\tDeparture: {this.Departure}\n\tRegister Date: {this.RegisterDate}\n\tValue: {this.Value}";
        }
    }
}
