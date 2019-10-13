using IdealWay.Application;
using IdealWay.Application.DeveloperUseCases.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.Presenters
{
    public class DeveloperListPresenter : IQueryResponse<List<DeveloperDto>>
    {
        public DeveloperListPresenter()
        {

        }

        public void Respond(List<DeveloperDto> response)
        {
            ContentResult = new JsonResult(response);
        }

        public JsonResult ContentResult { get; set; }
    }
}
