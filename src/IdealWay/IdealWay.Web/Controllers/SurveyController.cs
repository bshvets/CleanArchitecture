using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Application.SurveyAnswerUseCases.Commands;
using IdealWay.Web.Presenters;
using IdealWay.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdealWay.Web.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IGetAllDevelopersQuery _getAllDevelopersQuery;
        private readonly IAddSurveyResponseCommand _addSurveyResponseCommand;

        public SurveyController(IGetAllDevelopersQuery getAllDevelopersQuery,
            IAddSurveyResponseCommand addSurveyResponseCommand)
        {
            _getAllDevelopersQuery = getAllDevelopersQuery;
            _addSurveyResponseCommand = addSurveyResponseCommand;
        }

        // GET: Model for answer
        public async Task<ActionResult> Index([FromServices] SurveyAnswerPresenter surveyAnswerPresenter)
        {
            await _getAllDevelopersQuery.ExecuteAsync(surveyAnswerPresenter);
            return View(surveyAnswerPresenter.ContentResult);
        }

        // POST: SurveyAnswer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SurveyAnswerViewModel surveyAnswer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _addSurveyResponseCommand.Handle(new AddSurveyResponseRequest()
                    {
                        DeveloperId = surveyAnswer.SelectedDeveloperId,
                        Satisfied = surveyAnswer.IsSatisfied,
                        YearSalary = surveyAnswer.AnnualSalary
                    }, CancellationToken.None);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(nameof(Index), surveyAnswer);
                }
            }
            catch
            {
                return View(nameof(Index), surveyAnswer);
            }
        }        
    }
}