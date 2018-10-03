namespace _06.ParkingLot
{
using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var commandArgs = input.Split(", ");
                if (commandArgs[0]=="IN")
                {
                    cars.Add(commandArgs[1]);
                }
                else
                {
                    cars.Remove(commandArgs[1]);
                }
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
            Console.WriteLine(string.Join(Environment.NewLine,cars));
            }
        }
    }
}
