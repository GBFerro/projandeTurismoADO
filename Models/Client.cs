using System.Net;

namespace Models
{
    public class Client
    {
        public readonly static string INSERT = "insert into Client (Name, Phone, RegisterDate, IdAddress) " +
            "values (@Name, @Phone, @RegisterDate, @IdAddress); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select client.[Id] as IdClient, client.[Name] as NameClient, client.[Phone] as PhoneClient, " +
            "address.[Id] as IdAddress, address.[Street] as StreetAddress, address.[Number] as NumberAddress, address.[District] as DistrictAddress, " +
            "address.[ZipCode] as ZipAddress, address.[Complement] as ComplementAddress, city.[Id] as IdCity, city.[Name] as NameCity, " +
            "city.[RegisterDate] as RegisterCity, address.[RegisterDate] as RegisterAddress, " +
            "client.[RegisterDate] as RegisterClient " +
            "from[Client] client join[Address] address on client.[IdAddress] = address.[Id]" +
            "join[City] city on city.[Id] = address.[IdCity]";

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            //return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return $"\n\tId: {this.Id}\n\tName: {this.Name}\n\tPhone: {this.Phone}\n\tAddress: {this.Address}\n\tRegister Date: {this.RegisterDate}";
        }
    }
}