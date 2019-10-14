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

        public DeveloperController(IGetAllDevelopersQuery getAllDevelopersQuery)
        {
            _getAllDevelopersQuery = getAllDevelopersQuery;
        }

        // GET: Developer
        public async Task<ActionResult> Index([FromServices] DeveloperListPresenter developerListPresenter)
        {
            await _getAllDevelopersQuery.ExecuteAsync(developerListPresenter);

            return View(developerListPresenter.ContentResult);
        }        
    }
}