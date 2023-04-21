﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class CityController
    {
        public readonly static string INSERT = "insert into City (Name, RegisterDate) " +
            "values (@Name, @RegisterDate); Select cast(scope_Identity() as int)";

        public readonly static string GETALL = "select Id , Name, RegisterDate from City";

        private CityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }

        public bool InsertCity(City city)
        {
            bool status = false;
            try
            {
                _cityService.InsertCity(city, INSERT);
                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
        }

        public int UpdateCity()
        {
            return 0;
        }

        public int DeleteCity()
        {
            return 0;
        }

        public List<City> FindAll()
        {
            return _cityService.FindAll(GETALL);
        }
    }
}
