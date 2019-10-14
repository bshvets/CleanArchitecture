using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdealWay.Web.Controllers
{
    public class SurveyResultsController : Controller
    {
        // GET: SurveyResults
        public ActionResult Index()
        {
            return View();
        }

        // GET: SurveyResults/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SurveyResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyResults/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SurveyResults/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SurveyResults/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SurveyResults/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SurveyResults/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}