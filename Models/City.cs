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
        
        public readonly static string GETALL = "select Id , Name, RegisterDate from City";
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string? ToString()
        {
            return $"\n\t\t\tId: {this.Id}\n\t\t\tCity Name: {this.Name}\n\t\t\tRegister Date: {this.RegisterDate}";
        }
    }
}
