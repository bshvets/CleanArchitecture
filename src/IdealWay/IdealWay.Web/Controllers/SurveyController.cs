﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Web.Presenters;
using IdealWay.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdealWay.Web.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IGetAllDevelopersQuery _getAllDevelopersQuery;

        public SurveyController(IGetAllDevelopersQuery getAllDevelopersQuery)
        {
            _getAllDevelopersQuery = getAllDevelopersQuery;
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

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(nameof(Index), surveyAnswer);
                }
            }
            catch
            {
                return View(surveyAnswer);
            }
        }        
    }
}