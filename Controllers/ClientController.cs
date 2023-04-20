using System;
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

                _clientService.InsertClient(client);

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
            return _clientService.FindAll();
        }
    }
}
