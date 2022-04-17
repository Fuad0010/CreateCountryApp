using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CountryService : ICountry
    {
        public static int Count { get; set; }
        private CountryRepository _countryRepository; 
        public CountryService ()
        {
            _countryRepository = new CountryRepository();
        }

        public Country Create(Country country)
        {
            country.Id = Count;
            
            _countryRepository.Create(country);
            Count++;
            return country;
        }

        public Country Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(string name)
        {
            return _countryRepository.GetOne();
        }

        public Country Update(int id, Country country)
        {
            throw new NotImplementedException();
        }
        public List<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }



    }
}
