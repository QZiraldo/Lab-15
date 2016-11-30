using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Country List Application\n\nPlease Select one of these three options:\n1: View List of Countries\n2: Add a Country\n3: Exit");




            int UserResponse = Convert.ToInt16(Console.ReadLine());

            if (UserResponse == 1)
            {
             CountriesTextFile.ReadFile();
            }

            else if (UserResponse ==2)
            {
                CountriesTextFile.AddCountries(Console.ReadLine());
            }

            else if (UserResponse == 3)
            {
                Console.WriteLine("Goodbye!");
               
            }

            else
            {
                Console.WriteLine("Invalid Entry, please enter 1, 2, or 3");
                UserResponse = Convert.ToInt16(Console.ReadLine());

            }

        }
    }
}
