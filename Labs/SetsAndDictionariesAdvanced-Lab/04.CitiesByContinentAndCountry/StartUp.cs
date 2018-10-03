using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var citiesLocation = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var InputArgs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                StoreInformation(InputArgs, citiesLocation);
            }
            PrintResult(citiesLocation);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, HashSet<string>>> citiesLocation)
        {
            foreach (var continentCountry in citiesLocation)
            {
                Console.WriteLine($"{continentCountry.Key}:");
                foreach (var countryCities in continentCountry.Value)
                {
                    Console.WriteLine($"  {countryCities.Key} -> {string.Join(", ",countryCities.Value)}");
                }
            }
        }

        private static void StoreInformation(string[] inputArgs, Dictionary<string, Dictionary<string, HashSet<string>>> citiesLocation)
        {
            var continent = inputArgs[0];
            var country = inputArgs[1];
            var city = inputArgs[2];

            if (citiesLocation.ContainsKey(continent))
            {
                ImportCoutyAndCity(continent, country, city, citiesLocation);
               
            }
            else
            {
                citiesLocation.Add(continent, new Dictionary<string, HashSet<string>>());
                ImportCoutyAndCity(continent, country, city, citiesLocation);

            }
        }

        private static void ImportCoutyAndCity(string continent, string country, string city, Dictionary<string, Dictionary<string, HashSet<string>>> citiesLocation)
        {
            if (citiesLocation[continent].ContainsKey(country))
            {
                if (!citiesLocation[continent][country].Any(e=>e == city))
                {
                citiesLocation[continent][country].Add(city);
                }
            }
            else
            {
                citiesLocation[continent].Add(country, new HashSet<string>());
               
                citiesLocation[continent][country].Add(city);
            }
        }
    }
}
