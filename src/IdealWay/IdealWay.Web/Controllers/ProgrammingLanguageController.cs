using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdealWay.Application.ProgrammingLanguageUseCases.Queries;
using IdealWay.Web.Presenters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdealWay.Web.Controllers
{
    public class ProgrammingLanguageController : Controller
    {
        private readonly IGetMostUsedProgrammingLanguages _getMostUsedProgrammingLanguages;

        public ProgrammingLanguageController(IGetMostUsedProgrammingLanguages getMostUsedProgrammingLanguages)
        {
            _getMostUsedProgrammingLanguages = getMostUsedProgrammingLanguages;
        }

        // GET: ProgrammingLanguage
        public async Task<ActionResult> Index([FromServices] ProgrammingLanguageListPresenter programmingLanguageListPresenter)
        {
            await _getMostUsedProgrammingLanguages.ExecuteAsync(programmingLanguageListPresenter);

            return View(programmingLanguageListPresenter.ContentResult);
        }        
    }
}