select client.[Id] as IdClient, client.[Name] as NameClient, client.[Phone] as PhoneClient, 
[addressClient].[Id] as IdClientAddress, [addressClient].[Street] as StreetClientAddress, 
[addressClient].[Number] as NumberClientAddress, 
[addressClient].[District] as DistrictClientAddress, [addressClient].[ZipCode] as ZipClientAddress, 
[addressClient].[Complement] as ComplementClientAddress, 
cityClient.[Id] as IdClientCity, cityClient.[Name] as NameClientCity, 
cityClient.[RegisterDate] as RegisterClientCity, 
[addressClient].[RegisterDate] as RegisterClientAddress, 
client.[RegisterDate] as RegisterClient
from [Client] client join [Address] [addressClient] on client.[IdAddress] = [addressClient].[Id]
join [City] cityClient on cityClient.[Id] = [addressClient].[IdCity] 

select hotel.[Id] as IdHotel, hotel.[Name] as NameHotel, hotel.[Value] as ValueHotel,
address.[Id] as IdAddress, address.[Street] as StreetAddress, address.[Number] as NumberAddress, 
address.[District] as DistrictAddress, address.[ZipCode] as ZipAddress, 
address.[Complement] as ComplementAddress, city.[Id] as IdCity, city.[Name] as NameCity, 
city.[RegisterDate] as RegisterCity, address.[RegisterDate] as RegisterAddress, 
hotel.[RegisterDate] as RegisterHotel
from [Hotel] hotel join [Address] address on hotel.[IdAddress] = address.[Id]
join [City] city on city.[Id] = address.[Id] 

Select ticket.[Id] as TicketId, addressDeparture.[Id] as IdAddressDeparture, addressDeparture.[Street] as StreetAddressDeparture, 
addressDeparture.[Number] as NumberAddressDeparture, addressDeparture.[District] as DistrictAddressDeparture, 
addressDeparture.[ZipCode] as ZipAddressDeparture, addressDeparture.[Complement] as ComplementAddressDeparture, 
cityDeparture.[Id] as IdCityDeparture, cityDeparture.[Name] as NameCityDeparture, cityDeparture.[RegisterDate] as RegisterCityDeparture, 
addressDeparture.[RegisterDate] as RegisterAddressDeparture,
addressArrival.[Id] as IdAddressArrival, addressArrival.[Street] as StreetAddressArrival, addressArrival.[Number] as NumberAddressArrival, addressArrival.[District] as DistrictAddressArrival, addressArrival.[ZipCode] as ZipAddressArrival, addressArrival.[Complement] as ComplementAddressArrival, cityArrival.[Id] as IdCityArrival, cityArrival.[Name] as NameCityArrival, cityArrival.[RegisterDate] as RegisterCityArrival, addressArrival.[RegisterDate] as RegisterAddressArrival,
ticket.[Value] as ValueTicket, ticket.[RegisterDate] as RegisterTicket
from [Ticket] ticket 
join [Address] addressArrival on ticket.Arrival = addressArrival.Id 
join [City] cityArrival on addressArrival.Id = cityArrival.Id 
join [Address] addressDeparture on ticket.Departure = addressDeparture.Id 
join [City] cityDeparture on addressDeparture.Id = cityDeparture.Id


select package.[Id] as IdPackage, package.[Value] as ValuePackage, package.[RegisterDate] as RegisterPackage, 
hotel.[Id] as IdHotel, hotel.[Name] as NameHotel, hotel.[Value] as ValueHotel,
addressHotel.[Id] as IdHotelAddress, addressHotel.[Street] as StreetHotelAddress, 
addressHotel.[Number] as NumberHotelAddress, 
addressHotel.[District] as DistrictHotelAddress, addressHotel.[ZipCode] as ZipHotelAddress, 
addressHotel.[Complement] as ComplementHotelAddress, 
cityHotel.[Id] as IdHotelCity, cityHotel.[Name] as NameHotelCity, 
cityHotel.[RegisterDate] as RegisterHotelCity, 
addressHotel.[RegisterDate] as RegisterHotelAddress, 
hotel.[RegisterDate] as RegisterHotel, 
ticket.[Id] as TicketId, addressDeparture.[Id] as IdAddressDeparture, 
addressDeparture.[Street] as StreetAddressDeparture, 
addressDeparture.[Number] as NumberAddressDeparture, addressDeparture.[District] as DistrictAddressDeparture, 
addressDeparture.[ZipCode] as ZipAddressDeparture, addressDeparture.[Complement] as ComplementAddressDeparture, 
cityDeparture.[Id] as IdCityDeparture, cityDeparture.[Name] as NameCityDeparture, 
cityDeparture.[RegisterDate] as RegisterCityDeparture, 
addressDeparture.[RegisterDate] as RegisterAddressDeparture,
addressArrival.[Id] as IdAddressArrival, addressArrival.[Street] as StreetAddressArrival, 
addressArrival.[Number] as NumberAddressArrival, addressArrival.[District] as DistrictAddressArrival, 
addressArrival.[ZipCode] as ZipAddressArrival, addressArrival.[Complement] as ComplementAddressArrival, 
cityArrival.[Id] as IdCityArrival, cityArrival.[Name] as NameCityArrival, 
cityArrival.[RegisterDate] as RegisterCityArrival, addressArrival.[RegisterDate] as RegisterAddressArrival,
ticket.[Value] as ValueTicket, ticket.[RegisterDate] as RegisterTicket, 
client.[Id] as IdClient, client.[Name] as NameClient, client.[Phone] as PhoneClient, 
[addressClient].[Id] as IdClientAddress, [addressClient].[Street] as StreetClientAddress, 
[addressClient].[Number] as NumberClientAddress, 
[addressClient].[District] as DistrictClientAddress, [addressClient].[ZipCode] as ZipClientAddress, 
[addressClient].[Complement] as ComplementClientAddress, 
cityClient.[Id] as IdClientCity, cityClient.[Name] as NameClientCity, 
cityClient.[RegisterDate] as RegisterClientCity, 
[addressClient].[RegisterDate] as RegisterClientAddress, 
client.[RegisterDate] as RegisterClient 
from [Package] package join [Hotel] hotel on package.[IdHotel] = hotel.[Id]
join [Address] addressHotel on hotel.[IdAddress] = addressHotel.[Id]
join [City] cityHotel on cityHotel.[Id] = addressHotel.[IdCity]
join [Ticket] ticket on package.[IdTicket] = ticket.[Id]
join [Address] addressArrival on ticket.[Arrival] = addressArrival.[Id] 
join [City] cityArrival on addressArrival.[IdCity] = cityArrival.[Id]
join [Address] addressDeparture on ticket.[Departure] = addressDeparture.[Id] 
join [City] cityDeparture on addressDeparture.[IdCity] = cityDeparture.[Id]
join [Client] client on package.[IdClient] = client.[Id] 
join [Address] [addressClient] on client.[IdAddress] = [addressClient].[Id]
join [City] cityClient on cityClient.[Id] = [addressClient].[IdCity]


select * from Package
select * from Client
select * from Ticket
select * from Hotel
select * from Address
select * from City


delete from City;
delete from Client;
delete from Address;
delete from Hotel;
delete from Package;
delete from Ticket;