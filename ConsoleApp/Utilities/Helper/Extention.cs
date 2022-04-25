﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public static class Extention
    {
        public static void Print (ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {
            CreateCountry = 1,
            UpdateCountry = 2,
            RemoveCountry = 3,
            GetCountry = 4,
            GetAllCountries = 5,
            Exit = 0
        }

    }
}
