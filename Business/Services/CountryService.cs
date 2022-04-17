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
            Country isExist = _countryRepository.GetOne(g => g.Id == Id);
            if (isExist==null)
            {
                return null;
            }
            _countryRepository.Delete(isExist);
            return isExist;
        }

        public Country GetCountry(string name)
        {
            return _countryRepository.GetOne(g=>g.Name==name);
        }

        public Country Update(int id, Country country)
        {
            throw new NotImplementedException();
        }
        public List<Country> GetAll(string name)
        {
            return _countryRepository.GetAll(g=>g.Name==name);
        }

        public Country GetCountry(int id)
        {
            return _countryRepository.GetOne(g=>g.Id==id);
        }

        
    }
}
