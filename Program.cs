using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Veribal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Франция";
            string country = "Париж";
            ShowInfo(country, city);
            (country, city) = (city, country);
            ShowInfo(country, city);
        }

        static void ShowInfo(string country, string city)
        {
            Console.WriteLine($"Столицей {country} является {city}");
        }
    }
}
