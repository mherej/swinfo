using SharpTrooper.Core;
using SharpTrooper.Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleSharpTrooper
{
    class Program
    {
       
        public static void Main(string[] args)
        {
           // GetSinglePlanet();
            //GetPeople();
            getAllPlanentTest();


        }// end main.

        // get all people.
        public static void GetPeople()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            SharpEntityResults<People> ListOfPeople = new SharpEntityResults<People>();
            ListOfPeople = core.GetAllPeople();// list of all people.
            List<People> WorkingListOfPeople = new List<People>();
            // add people to thbe workinf list.
            Console.WriteLine(" >>>>>>>>>>>>>>  The Star Wars Heros   <<<<<<<<<<<<<<");
            foreach ( People po in ListOfPeople.results)
            {
                WorkingListOfPeople.Add(po);
                Console.WriteLine(" Name _ {0}", po.name);
                Console.WriteLine(" Homeworld _ {0}", core.GetPHomeworld(po.homeworld));
                Console.WriteLine(" Skin Color _ {0}", po.skin_color);
                Console.WriteLine(" Gender _ {0}", po.gender);
                Console.WriteLine(" DOB _ {0}", po.birth_year);
                Console.WriteLine(" Appeard in :");
                // call for films for a person
                core.GetPfilm(po.url);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            }
            Console.WriteLine("Total Number Of Heroes - {0} ", WorkingListOfPeople.Count());
            Console.ReadLine();

        }//

        // get single planet details.
        public static void GetSinglePlanet()
        {
            SharpTrooperCore core = new SharpTrooperCore();

            Console.WriteLine("Enter Planet Number");
            string val = Console.ReadLine();
            try
            {
                var planet = core.GetPlanet(val);
                Console.WriteLine("Planet's Name: {0}", planet.name);
                Console.WriteLine("Rotation Period  {0}", planet.rotation_period);
                Console.WriteLine("Orbital Period  {0}", planet.orbital_period);
                Console.WriteLine("Diameter  {0}", planet.diameter);
                Console.WriteLine("Climate  {0}", planet.climate);
                Console.WriteLine("Population  {0}", planet.population);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }//

        public static void getAllPlanentTest()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            SharpEntityResults<Planet> planets = core.GetAllPlanets();
            List<Planet> ListOfPlanets = planets.results;
             foreach(Planet  p in ListOfPlanets)
            {
                Console.WriteLine("Name {0}",p.name);
            }
            Console.ReadLine();
        }





    }
}