using QuickWay.Application;
using QuickWay.Application.DeveloperUseCases.Dto;
using QuickWay.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.Presenters
{
    public class DeveloperListPresenter : IQueryResponse<List<DeveloperDto>>
    {
        public void Respond(List<DeveloperDto> response)
        {
            ContentResult = new DeveloperListViewModel()
            {
                Count = response.Count,
                Developers = response
                .Select(d => 
                    new DeveloperViewModel()
                    {
                        Id = d.DeveloperId,
                        DisplayName = d.FirstName + " " + d.LastName,
                        Gender = d.Gender,
                        Level = d.Level,
                        PrimaryLanguage = d.PrimaryLanguage,
                        YearsOfExperience = d.YearsOfExperience
                    })
                .ToList()
            };
        }

        public DeveloperListViewModel ContentResult { get; private set; }
    }
}
