using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        public readonly static string INSERT = "insert into City (Name, RegisterDate) " +
            "values (@Name, @RegisterDate); Select cast(scope_Identity() as int)";
        
        public readonly static string GETALL = "select Id, Name, RegisterDate from City c";
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string? ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
