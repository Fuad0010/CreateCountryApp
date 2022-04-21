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
        public static int Count = 1;
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

        public Country Delete(int Id)
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

        public Country Update(int id,Country country)
        {
            Country isExist = _countryRepository.GetOne(g => g.Id == id);
            if (isExist == null)
            {
                return null;
            }
            isExist.Name = country.Name;
            _countryRepository.Update(isExist);
            return isExist;
        }
        public List<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return _countryRepository.GetOne(g=>g.Id==id);
        }

        public List<Country> GetAll(string name = null)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD

        public Country Update(string id, Country country)
        {
            Country isExist = _countryRepository.GetOne(g => g.Name == id);
            if (isExist == null)
            {
                return null;
            }
            isExist.Name = country.Name;
            _countryRepository.Update(isExist);
            return isExist;
        }
=======
>>>>>>> 08e77844423d428f9589acdc8ffc6db0cbb24071
    }
}
