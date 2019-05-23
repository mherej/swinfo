using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace MVCSharpTrooper.Controllers
{
    public class PlanetController : Controller
    {
        // GET: Planet
        public ActionResult Index()
        {
            SharpTrooperCore core = new SharpTrooperCore();
            List<Planet> ListOfPlanets = new List<Planet>();
            List<Planet> AddOnList = new List<Planet>();
            for (int i = 1; i <= 6; i++)
            {
                SharpEntityResults<Planet> planets = core.GetAllPlanets(i.ToString());
                AddOnList = planets.results;
                foreach (var item in AddOnList)
                {
                    ListOfPlanets.Add(item);
                }
                
            }

            return View(ListOfPlanets);
        }

        // GET: Planet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Planet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Planet/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Planet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Planet/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
