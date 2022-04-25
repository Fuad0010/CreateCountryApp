using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using Utilities.Helper;

namespace CreateCountryApp.Controllers
{
    internal class CountryController
    {

        CountryService countryService = new CountryService();



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
            Extention.Print(ConsoleColor.Cyan, $"Please enter the country mile:");
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
                Extention.Print(ConsoleColor.Green, $"{country.Name} created.");

            }
            else
            {
                Console.Clear();
                Extention.Print(ConsoleColor.Red, "Please try again!");
                goto EnterName;
            }
        }
        public void GetAllCountries()
        {
            Console.Clear();
            foreach (var item in countryService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}.");
            }
        }
        public void RemoveCountry()

        {
        RestartMenu: Console.Clear();
            Extention.Print(ConsoleColor.Cyan, "Please enter the country ID for remove.");




            foreach (var item in countryService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"ID:{item.Id} {item.Name}.");

            }
            int id = int.Parse(Console.ReadLine());
            if (id > DataContext.Countries.Count)
            {
                Extention.Print(ConsoleColor.Red, "Please choose current the ID.");
                goto RestartMenu;
            }

            Console.Clear();
            Extention.Print(ConsoleColor.Red, $"{countryService.Delete(id).Name} is removed.");
        }
        public void GetCountry()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Cyan, "Please enter the country ID or name of counry for get.\n" +
                                               "Country list:");
        Current:
            foreach (var item in countryService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"\"ID:{item.Id} {item.Name}.\"");
            }
            string num = Console.ReadLine();
            int input;

            bool IsNum = int.TryParse(num, out input);

            try
            {
                if (IsNum)
                {
                    Console.Clear();
                    Extention.Print(ConsoleColor.Green, $"{countryService.GetCountry(input).Name}");
                }
                else
                {
                    Console.Clear();
                    Extention.Print(ConsoleColor.Green, $"{countryService.GetCountry(num).Name}");
                }
            }
            catch (Exception)
            {

                Extention.Print(ConsoleColor.Red, "Please enter the country ID or name of counry for get.\n" +
                                                   "Country list:");
                goto Current;
            }


        }
        public void UpdateCountry()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Cyan, "Please enter the country ID for update.\n" +
                                               "Country list:");
            Update:

            foreach (var item in countryService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"\"ID:{item.Id} {item.Name}.\"");
            }
            int id;
            
            id = Convert.ToInt32(Console.ReadLine());

            if (!(id >= CountryService.Count))
            {

                string countryNewName;

                Extention.Print(ConsoleColor.Cyan, "Please enter the new country.");

                countryNewName = (Console.ReadLine());

                Country cntry = new Country()
                {
                    Name = countryNewName,
                };
                countryService.Update(id, cntry);
                Console.Clear();
                Extention.Print(ConsoleColor.Green, $"{cntry.Name} updated!");
            }
            else
            {
                Console.Clear();
                Extention.Print(ConsoleColor.Red, "Please enter the country ID for update.\n" +
                                                   "Country list:");
                goto Update;
            }
        }
        public void MenuExit()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Cyan, "Good Bye");
            System.Environment.Exit(0);
        }
    }
}
