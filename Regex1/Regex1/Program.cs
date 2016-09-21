using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Uppgift 4
            //bool running = true;
            //while (running)
            //{
            //    Console.WriteLine("Ange personnummer");
            //    string input = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(input, "^(19|20)?((?:[0-9]{2}[- ]?)(?!02[- ]?(29|30|31)|(04|06|09|11)[- ]?31)(?:(?:0[1-9]|1[0-2])[- ]?(?:[0-2][1-9]|3[0-1])[-+ ]?[0-9]{4}))$")
            //        ? "Giltligt!"
            //        : "Ej giltligt, försök igen!");
            //}

            //// Uppgift 5 (man kan använda i i regex men .ToLower() är bättre!)
            //while (true)
            //{
            //    Console.WriteLine("input text");
            //    string input = Console.ReadLine().ToLower();
            //    Console.WriteLine(Regex.Matches(input, "\\bdet\\b").Count);
            //}
        }
    }
}
