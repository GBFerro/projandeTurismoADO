using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Package
    {
        public readonly static string INSERT = "insert into Package (IdHotel, IdTicket, IdClient, RegisterDate, Value) " +
            "values (@IdHotel, @IdTicket, @IdClient, @RegisterDate, @Value); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select package.[Id] as IdPackage, " +
            "package.[Value] as ValuePackage, package.[RegisterDate] as RegisterPackage, " +
            "hotel.[Id] as IdHotel, hotel.[Name] as NameHotel, hotel.[Value] as ValueHotel, " +
            "addressHotel.[Id] as IdHotelAddress, addressHotel.[Street] as StreetHotelAddress, " +
            "addressHotel.[Number] as NumberHotelAddress, addressHotel.[District] as DistrictHotelAddress, " +
            "addressHotel.[ZipCode] as ZipHotelAddress, addressHotel.[Complement] as ComplementHotelAddress, " +
            "\r\ncityHotel.[Id] as IdHotelCity, cityHotel.[Name] as NameHotelCity, " +
            "cityHotel.[RegisterDate] as RegisterHotelCity, " +
            "addressHotel.[RegisterDate] as RegisterHotelAddress, " +
            "hotel.[RegisterDate] as RegisterHotel, ticket.[Id] as TicketId, " +
            "addressDeparture.[Id] as IdAddressDeparture, " +
            "addressDeparture.[Street] as StreetAddressDeparture, " +
            "addressDeparture.[Number] as NumberAddressDeparture, " +
            "addressDeparture.[District] as DistrictAddressDeparture, " +
            "addressDeparture.[ZipCode] as ZipAddressDeparture, " +
            "addressDeparture.[Complement] as ComplementAddressDeparture, " +
            "cityDeparture.[Id] as IdCityDeparture, cityDeparture.[Name] as NameCityDeparture, " +
            "cityDeparture.[RegisterDate] as RegisterCityDeparture, " +
            "addressDeparture.[RegisterDate] as RegisterAddressDeparture, " +
            "addressArrival.[Id] as IdAddressArrival, addressArrival.[Street] as StreetAddressArrival, " +
            "addressArrival.[Number] as NumberAddressArrival, " +
            "addressArrival.[District] as DistrictAddressArrival, " +
            "addressArrival.[ZipCode] as ZipAddressArrival, " +
            "addressArrival.[Complement] as ComplementAddressArrival, " +
            "cityArrival.[Id] as IdCityArrival, cityArrival.[Name] as NameCityArrival, " +
            "cityArrival.[RegisterDate] as RegisterCityArrival, " +
            "addressArrival.[RegisterDate] as RegisterAddressArrival, " +
            "ticket.[Value] as ValueTicket, ticket.[RegisterDate] as RegisterTicket, " +
            "client.[Id] as IdClient, client.[Name] as NameClient, client.[Phone] as PhoneClient, " +
            "[addressClient].[Id] as IdClientAddress, [addressClient].[Street] as StreetClientAddress, " +
            "[addressClient].[Number] as NumberClientAddress, " +
            "[addressClient].[District] as DistrictClientAddress, " +
            "[addressClient].[ZipCode] as ZipClientAddress, " +
            "[addressClient].[Complement] as ComplementClientAddress, " +
            "cityClient.[Id] as IdClientCity, cityClient.[Name] as NameClientCity, " +
            "cityClient.[RegisterDate] as RegisterClientCity, " +
            "[addressClient].[RegisterDate] as RegisterClientAddress, " +
            "client.[RegisterDate] as RegisterClient " +
            "from [Package] package join [Hotel] hotel on package.[IdHotel] = hotel.[Id] " +
            "join [Address] addressHotel on hotel.[IdAddress] = addressHotel.[Id] " +
            "join [City] cityHotel on cityHotel.[Id] = addressHotel.[IdCity] " +
            "join [Ticket] ticket on package.[IdTicket] = ticket.[Id] " +
            "join [Address] addressArrival on ticket.[Arrival] = addressArrival.[Id] " +
            "join [City] cityArrival on addressArrival.[IdCity] = cityArrival.[Id] " +
            "join [Address] addressDeparture on ticket.[Departure] = addressDeparture.[Id] " +
            "join [City] cityDeparture on addressDeparture.[IdCity] = cityDeparture.[Id] " +
            "join [Client] client on package.[IdClient] = client.[Id] " +
            "join [Address] [addressClient] on client.[IdAddress] = [addressClient].[Id] " +
            "join [City] cityClient on cityClient.[Id] = [addressClient].[IdCity]";

        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public Client Client { get; set; }
        public decimal Value { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            //return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return $"Id: {this.Id}\nHotel: {this.Hotel}\nTicket: {this.Ticket}\nClient: {this.Client}\nRegister Date: {this.RegisterDate}\nValue: {this.Value}";
        }
    }
}
