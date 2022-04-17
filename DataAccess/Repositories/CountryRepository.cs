using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CountryRepository:IRepository<Country>
    {
        public bool Create(Country entity)
        {
            try
            {
                DataContext.Countries.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Country entity)
        {
            try
            {
                DataContext.Countries.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Country> GetAll(Predicate<Country> filter = null)
        {
            try
            {
                return DataContext.Countries.FindAll(filter);
            }
            catch (Exception)
            {
                 
                throw;
            }
        }

        public Country GetOne(Predicate<Country> filter = null)
        {
            try
            {
                return filter == null? DataContext.Countries[0]: 
                    DataContext.Countries.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Country entity)
        {
            try
            {
                Country isExist = GetOne(c => c.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
