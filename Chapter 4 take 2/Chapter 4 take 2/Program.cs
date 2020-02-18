using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_4_take_2
{
    class Program
    {
        private static IEnumerable<string> planetList2;
        private static object allPlanetList;
        private static List<string> list;

        static void Main(string[] args)
        {
            ///////////////////Planets exercise/////////////////////
            
            
            ///// (1) Add() Jupiter and Saturn at the end of the list.//

            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupitor");

            planetList.Add("Saturn");

            //Console.WriteLine("planetList");

            // (2) Create another List that contains that last two planet of our solar system.// 

            List<string> planetList2 = new List<string>()
            { "Neptune","Uranus"};


            Console.WriteLine("Title - aqllPlanets listafter we add them");

            // (3) Combine the two lists by using AddRange().//

            planetList.AddRange(planetList2);


            // (4) Use Add() again to add Pluto to the end of the list.//

            planetList.Insert(2, "Venus");

            planetList.Insert(3, "Earth");
            
            planetList.ForEach(planet => Console.WriteLine(planet));

            // (5) Use Add() again to add Pluto to the end of the list.

            planetList.Insert(1, "Pluto");

            // (6) Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.//
            List<string> rockyPlanets = planetList.GetRange(1, 4);

            planetList.Insert(1, "Mercury");

            planetList.Insert(2, "Venus");

            planetList.Insert(3, "Earth");

            planetList.Insert(4, "Mars");

            planetList.ForEach(planet => Console.WriteLine(planet));

            rockyPlanets.ForEach(planet => Console.WriteLine(planet));



        }

        
        
    }
}
