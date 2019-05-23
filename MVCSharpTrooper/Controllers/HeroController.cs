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
            SharpTrooperCore core = new SharpTrooperCore();
            SharpEntityResults<People> list = core.GetAllPeople();
            List<People> StarWarsHeros = list.results;


            return View(StarWarsHeros);
        }
    }
}