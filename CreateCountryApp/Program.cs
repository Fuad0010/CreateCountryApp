using Business.Services;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace CreateCountryApp
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.Magenta, "Welcome");
            while (true)
            {
                CountryService countryService = new CountryService();



                Extention.Print(ConsoleColor.Cyan, "1. Create Country\n" +
                                                   "2. Update Countryn\n" +
                                                   "3. Remove Country\n" +
                                                   "4. Get Country\n" +
                                                   "5. Get All Countries");

                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input > 0 && input < 7)
                {

                    switch (input)
                    {
                        case (int)Extention.Menu.CreateCountry:
                        EnterName:
                            Extention.Print(ConsoleColor.Cyan, $"Please enter the country name:");
                            string name = Console.ReadLine();
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
                                Extention.Print(ConsoleColor.Green, $"{country.Name} created");

                            }
                            else
                            {
                                Extention.Print(ConsoleColor.Red, "Try Again");
                                goto EnterName;
                            }
                            break;
                        case (int)Extention.Menu.UpdateCountry:

                            break;
                        case (int)Extention.Menu.RemoveCountry:

                            break;
                        case (int)Extention.Menu.GetCountry:

                            break;
                        case (int)Extention.Menu.GetAllCountries:
                            string name2 = Console.ReadLine();
                            Country list = countryService.GetCountry(name2);

                            Extention.Print(ConsoleColor.Yellow, $"{list.Name}");
                            break;

                    }
                }





            }


        }
    }
}

