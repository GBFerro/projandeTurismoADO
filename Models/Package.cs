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

        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public Client Client { get; set; }
        public decimal Value { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
