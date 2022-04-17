using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICountry
    {
        Country Create(Country country);
        Country Update(int id, Country country);
        Country Delete (int id);
        Country GetCountry(string name);
        Country GetCountry(int id);
        List<Country> GetAll(string name=null);



    }
}
