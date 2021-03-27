using System;
using System.Collections.Generic;

namespace Classes_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // more comments in each file

            // created a new suv with subaru specific proprieties, using SubaruFactory
            Suv subaru_forester = SubaruFactory.CreateSubaruForester(2021);
            Console.WriteLine(subaru_forester.GetInformation());

            // created another suv using subaruFactory, but with other parameters
            Suv subaru_forester_2 = SubaruFactory.CreateSubaruForester(2018, color: "pink", special_feature: "with diamonds");
            Console.WriteLine(subaru_forester_2.GetInformation());

            // created another suv using suv constructor
            Suv suzuki_jimny = new Suv("suzuki jimny", 2009, 85);
            Console.WriteLine(suzuki_jimny.GetInformation());

            // created a new sedan using sedan constructor
            Sedan nissan_sentra = new Sedan("nissan sentra", 2005, 126);
            Console.WriteLine(nissan_sentra.GetInformation());

            // created a new motorcycle using motorcycle constructor
            Motorcycle honda_monkey = new Motorcycle("honda monkey", 2018, 9);
            Console.WriteLine(honda_monkey.GetInformation());

            // created a list of all vehicles that implement the interface iDriveable

            List<iDriveable> vehicle = new List<iDriveable>();
            vehicle.Add(subaru_forester);
            vehicle.Add(suzuki_jimny);
            vehicle.Add(nissan_sentra);
            vehicle.Add(honda_monkey);

            // for each element in the list, we can call the methods of the interface

            foreach (iDriveable element in vehicle)
            {
                Console.WriteLine(element.Drive());
                Console.WriteLine(element.Turn());
            };
        }
    }
}
