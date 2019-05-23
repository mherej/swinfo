using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace MVCSharpTrooper.Controllers
{
    public class SpecieController : Controller
    {
        // GET: Specie
        public ActionResult Index()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            SharpEntityResults<Specie> list = core.GetAllSpecies();
            List<Specie> StarWarsSpecie = list.results;
            return View(StarWarsSpecie);
        }
    }
}