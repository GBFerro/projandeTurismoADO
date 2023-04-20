using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hotel
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
            "from[Hotel] hotel join[Address] address on hotel.[IdAddress] = address.[Id] " +
            "join[City] city on city.[Id] = address.[IdCIty]";

        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public decimal Value { get; set; }

        public override string ToString()
        {
            //return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return $"\n\tId: {this.Id}\n\tName: {this.Name}\n\tAddress: {this.Address}\n\tRegister Date: {this.RegisterDate}\n\tValue: {this.Value}";
        }
    }
}
