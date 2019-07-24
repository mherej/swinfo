using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace StarWarsWebApi.Controllers
{
    public class herosController : Controller
    {
        // GET: heros
        public ActionResult Index()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            string peoplesUrl = "https://swapi.co/api/people";
            string res = core.GetByUrl(peoplesUrl);

            return View(res);
        }
    }
}