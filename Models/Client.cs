namespace Models
{
    public class Client
    {
        public readonly static string INSERT = "insert into Client (Name, Phone, RegisterDate, IdAddress) " +
            "values (@Name, @Phone, @RegisterDate, @IdAddress); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select cl.Id, cl.Name, cl.Phone, a.Street, " +
            "a.Number, a.District, a.ZipCode, a.Complement, c.Name, a.RegisterDate, cl.RegisterDate " +
            "from Client cl join Address a on cl.IdAddress = a.Id join City c on a.Id = c.Id";

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}