﻿using IdealWay.Application;
using IdealWay.Application.DeveloperUseCases.Dto;
using IdealWay.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.Presenters
{
    public class SurveyAnswerPresenter : IQueryResponse<List<DeveloperDto>>
    {
        public void Respond(List<DeveloperDto> response)
        {
            ContentResult = new SurveyAnswerViewModel()
            {
                Developers = response
                    .Select(d =>
                            new SelectListItem()
                            {
                                Value = d.DeveloperId.ToString(),
                                Text = d.FirstName + " " + d.LastName
                            })
                    .ToList()
            };
        }

        public SurveyAnswerViewModel ContentResult { get; private set; }
    }
}
