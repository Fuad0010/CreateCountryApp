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

            Extention.Print(ConsoleColor.Yellow, "Welcome To Creater Countries & Cities");
            


                CountryController countryController = new CountryController();
                Up:
                Extention.Print(ConsoleColor.Cyan, "1. Create Country\n" +
                                                   "0. Exit");
                try
                {
                int numm = Convert.ToInt32(Console.ReadLine());
                

                Console.Clear();

                if (numm >= 0 && numm < 2)
                {

                    switch (numm)
                    {
                        case (int)Extention.Menu.Exit:
                            countryController.MenuExit();
                            break;
                        case (int)Extention.Menu.CreateCountry:
                            countryController.CreateCountry();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Extention.Print(ConsoleColor.Red, "Please choose current menu.");
                    goto Up;
                }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Extention.Print(ConsoleColor.Red, "Please choose current menu.");
                    goto Up;
                }
            while (true)
            {
            RestartMenu:

                Extention.Print(ConsoleColor.Cyan, "1. Create Country.\n" +
                                                   "2. Update Country.\n" +
                                                   "3. Remove Country.\n" +
                                                   "4. Get Country.\n" +
                                                   "5. Get All Countries.\n" +
                                                   "0. Exit.");


                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                
                Console.Clear();


                if (IsNum && input >= 0 && input < 6)
                {
                    
                    
                    switch (input)
                    {
                        case (int)Extention.Menu.CreateCountry:            // 1    
                           countryController.CreateCountry();
                            break;
                        case (int)Extention.Menu.UpdateCountry:            // 2
                            countryController.UpdateCountry();
                            break;
                        case (int)Extention.Menu.RemoveCountry:            // 3
                            countryController.RemoveCountry();
                            break;
                        case (int)Extention.Menu.GetCountry:               // 4
                            countryController.GetCountry();
                            break;
                        case (int)Extention.Menu.GetAllCountries:          // 5
                            countryController.GetAllCountries();
                            break;
                        case (int)Extention.Menu.Exit:                     // 0
                            countryController.MenuExit();
                            break;
                    }
                }
                else
                {
                    Extention.Print(ConsoleColor.Red, "Please choose current menu.");
                    goto RestartMenu;
                }
            }
        }
    }
}

