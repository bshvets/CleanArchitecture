using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Web.Presenters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdealWay.Web.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IGetAllDevelopersQuery _getAllDevelopersQuery;
        private readonly DeveloperListPresenter _developerListPresenter;

        public DeveloperController(IGetAllDevelopersQuery getAllDevelopersQuery, 
            DeveloperListPresenter developerListPresenter)
        {
            _getAllDevelopersQuery = getAllDevelopersQuery;
            _developerListPresenter = developerListPresenter;
        }

        // GET: Developer
        public async Task<ActionResult> Index()
        {
            await _getAllDevelopersQuery.ExecuteAsync(_developerListPresenter);

            return View(_developerListPresenter.ContentResult);
        }

        // GET: Developer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Developer/Create
        public ActionResult Create()
        {
            return View();
        }        

        // POST: Developer/Create
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

        // GET: Developer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Developer/Edit/5
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

        // GET: Developer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Developer/Delete/5
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