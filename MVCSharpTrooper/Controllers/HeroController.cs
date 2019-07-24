using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace MVCSharpTrooper.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            SharpTrooperCore core = new SharpTrooperCore();//ecess core 
            List<People> ListOfPeople = new List<People>();

            List<People> AddOnList = new List<People>();//
            for (int i = 1; i <= 9; i++)
            {
                SharpEntityResults<People> people = core.GetAllPeople(i.ToString());// up tp 9 pages in the swapi
                AddOnList = people.results;
                foreach (var item in AddOnList)
                {
                    ListOfPeople.Add(item);
                }

            }

            return View(ListOfPeople);
        }
    }
}