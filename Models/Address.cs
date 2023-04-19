using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        public readonly static string INSERT = "insert into Address (Street, Number, District, ZipCode, Complement, RegisterDate, IdCity) " +
            "values (@Street, @Number, @District, @ZipCode, @Complement, @RegisterDate, @IdCity); Select cast(scope_Identity() as int)";
        
        public readonly static string GETALL = "select a.Id, a.Street, a.Number, a.District, a.ZipCode, " +
            "a.Complement, c.Name, a.RegisterDate from Address a join City c on a.Id = c.Id";

        public int Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? District { get; set; }
        public string? ZipCode { get; set; }
        public string? Complement { get; set; }
        public City City { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
