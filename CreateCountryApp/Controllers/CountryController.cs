using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace CreateCountryApp.Controllers
{
    internal class CountryController
    {
        private CountryService countryService;

        public CountryController()
        {
            countryService = new CountryService();
        }
        public void CreateCountry()
        {
            Console.Clear();
        EnterName:
            Extention.Print(ConsoleColor.Cyan, $"Please enter the country name:");
            string name = Console.ReadLine();
            Console.Clear();
            Extention.Print(ConsoleColor.Cyan, $"Please enter the country size:");
            string countrySize = Console.ReadLine();
            int size;


            bool isSize = int.TryParse(countrySize, out size);
            if (isSize)
            {
                Country country = new Country
                {
                    Name = name,
                    MaxSize = size
                };

                countryService.Create(country);
                Console.Clear();
                Extention.Print(ConsoleColor.Green, $"{country.Name} created");

            }
            else
            {
                Console.Clear();
                Extention.Print(ConsoleColor.Red, "Please try again!");
                goto EnterName;
            }
        }


    }
}
