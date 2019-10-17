using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickWay.Application.SalaryStatisticsUseCases.Queries;
using QuickWay.Web.Presenters;
using QuickWay.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuickWay.Web.Controllers
{
    public class SurveyResultsController : Controller
    {
        // GET: SurveyResults
        public ActionResult Index()
        {
            return View(new SurveyStatisticViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> Generate(SurveyStatisticViewModel surveyStatistic, 
            [FromServices] IGetAverageByGenderQuery getAverageByGenderQuery,
            [FromServices] IGetAverageByLevelQuery getAverageByLevelQuery,
            [FromServices] SurveyStatisticsPresenter surveyStatisticsPresenter)
        {
            if (surveyStatistic.AverageByLevel.HasValue)
            {
                if (surveyStatistic.AverageByLevel == true)
                {
                    await getAverageByLevelQuery.ExecuteAsync(surveyStatisticsPresenter);
                }
                else
                {
                    await getAverageByGenderQuery.ExecuteAsync(surveyStatisticsPresenter);
                }

                surveyStatistic.Data = surveyStatisticsPresenter.ContentResult;
            }
            return View(nameof(Index), surveyStatistic);
        }
    }
}