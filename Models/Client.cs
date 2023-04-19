namespace Models
{
    public class Client
    {
        public readonly static string INSERT = "insert into Client (Name, Phone, RegisterDate, IdAddress) " +
            "values (@Name, @Phone, @RegisterDate, @IdAddress); Select cast(scope_Identity() as int)";
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}