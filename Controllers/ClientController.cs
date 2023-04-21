﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class ClientController
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

        private ClientService _clientService;
        //private AddressService _addressService;
        //private CityService _cityService;

        public ClientController()
        {
            _clientService = new ClientService();
            //_addressService = new AddressService();
            //_cityService = new CityService();
        }
        public bool InsertClient(Client client)
        {
            bool status = false;
            try
            {
                //client.Address.City = _cityService.InsertCity(client.Address.City);
                //client.Address = _addressService.InsertAddress(client.Address);
                new AddressController().InsertAddress(client.Address);

                _clientService.InsertClient(client, INSERT);

                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }
            return status;
        }

        public int UpdateClient()
        {
            return 0;
        }

        public int DeleteClient()
        {
            return 0;
        }

        public List<Client> FindAll()
        {
            return _clientService.FindAll(GETALL);
        }
    }
}
