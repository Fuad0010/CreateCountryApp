using Business.Services;
using CreateCountryApp.Controllers;
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
                CountryController countryController = new CountryController();



                Extention.Print(ConsoleColor.Cyan, "1. Create Country\n" +
                                                   "2. Update Countryn\n" +
                                                   "3. Remove Country\n" +
                                                   "4. Get Country\n" +
                                                   "5. Get All Countries");

                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input > 0 && input < 6)
                {

                    switch (input)
                    {
                        
                        case (int)Extention.Menu.CreateCountry:            // 1    
                           countryController.CreateCountry();
                            break;
                        case (int)Extention.Menu.UpdateCountry:            // 2

                            break;
                        case (int)Extention.Menu.RemoveCountry:            // 3

                            break;
                        case (int)Extention.Menu.GetCountry:               // 4

                            break;
                        case (int)Extention.Menu.GetAllCountries:          // 5
                            countryController.GetAllCountry();
                            break;

                    }
                }





            }


        }
    }
}

