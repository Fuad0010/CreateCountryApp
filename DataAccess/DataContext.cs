using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext
    {
        public static List<City> Cities { get; set; }
        public static List<Country> Countries { get; set; }

        static DataContext()
        {
            Cities = new List<City>();
            Countries = new List<Country>();
        }

    }
}
