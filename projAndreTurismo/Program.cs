using Controllers;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto - Andre Turismo");

        Console.WriteLine("Teste inclusão de dados");

        /*
        Package package = new Package()
        {
            Hotel = new Hotel()
            {
                Name = "Hotel Fasano Rio de Janeiro",
                Address = new Address()
                {
                    Street = "Avenida Vieira Souto",
                    Number = 80,
                    District = "Ipanema",
                    ZipCode = "22420002",
                    Complement = "null",
                    City = new City()
                    {
                        Name = "Rio de Janeiro",
                        RegisterDate = DateTime.Now
                    },
                    RegisterDate = DateTime.Now
                },
                Value = 500,
                RegisterDate = DateTime.Now
            },
            Ticket = new Ticket()
            {
                Departure = new Address()
                {
                    Street = "Rodovia Hélio Smidt",
                    Number = 123,
                    District = "Cumbica",
                    ZipCode = "07190100",
                    Complement = "null",
                    City = new City()
                    {
                        Name = "São Paulo",
                        RegisterDate = DateTime.Now
                    },
                    RegisterDate = DateTime.Now
                },
                Arrival = new Address()
                {
                    Street = "Avenida Vinte de Janeiro",
                    Number = 321,
                    District = "Galeão",
                    ZipCode = "21941900",
                    Complement = "null",
                    City = new City()
                    {
                        Name = "Rio de Janeiro",
                        RegisterDate = DateTime.Now
                    },
                    RegisterDate = DateTime.Now
                },
                Value = 100,
                RegisterDate = DateTime.Now
            },
            Client = new Client()
            {
                Name = "Ana Silva",
                Phone = "11987654321",
                Address = new Address()
                {
                    Street = "Rua das Flores",
                    Number = 123,
                    District = "Jardim Paulista",
                    ZipCode = "01423001",
                    Complement = "apto 456",
                    City = new City()
                    {
                        Name = "São Paulo",
                        RegisterDate = DateTime.Now
                    },
                    RegisterDate = DateTime.Now
                },
                RegisterDate = DateTime.Now
            },
            Value = 2600,
            RegisterDate = DateTime.Now
        };

        Console.WriteLine(new PackageController().InsertPackage(package) ? "Inserido" : "Erro");
    */
        new PackageController().FindAll().ForEach(x => Console.WriteLine(x + "\n\n"));
    }
}