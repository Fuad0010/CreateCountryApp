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
    public class CityRepository : IRepository<City>
    {
        public bool Create(City entity)
        {
            try
            {
                DataContext.Cities.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(City entity)
        {
            try
            {
                DataContext.Cities.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<City> GetAll(Predicate<City> filter = null)
        {
            try
            {
                return DataContext.Cities.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public City GetOne(Predicate<City> filter = null)
        {
            try
            {
                return filter == null? DataContext.Cities[0]: 
                    DataContext.Cities.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(City entity)
        {
            try
            {
                City isExist = GetOne(c => c.Id == entity.Id);
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
