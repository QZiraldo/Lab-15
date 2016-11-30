using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesTextFile
    {
        List<Country> CountryList = new List<Country>();



        private static void AddCountry(string name, string salary)
        {
            StreamWriter sw = new StreamWriter("../../Countries.txt", true);
            sw.Write("\n{name}");
            sw.Close();
        }

        public static List<Country> ReadFile()
        {

            string filelocation = "../../Countries.txt";

            StreamReader reader = new StreamReader(filelocation);

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');


        }
        reader.Close();
            return CountryList;
        }





}
    }

