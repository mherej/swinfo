using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace MVCSharpTrooper.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            SharpEntityResults<Film> list = core.GetAllFilms();
            List<Film> StarWarsEpizods = list.results;
            return View( StarWarsEpizods);
        }
    }
}