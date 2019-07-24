using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace MVCSharpTrooper.Controllers
{
    public class StarshipController : Controller
    {
        SharpTrooperCore core = new SharpTrooperCore();
        // GET: Starship
        public ActionResult Index()
        {
            
            
            List<Starship> AdOnList = new List<Starship>();
            List<Starship> Starships = new List<Starship>();
            
            for (int i = 1; i<= 4; i++)
            {
                SharpEntityResults<Starship> list = core.GetAllStarships(i.ToString());
                AdOnList = list.results;
                // ad to total for every ship
                foreach (var item in AdOnList)
                {
                    Starships.Add(item);
                }
            }



            return View(Starships);
        }
    }
}