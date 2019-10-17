using QuickWay.Application;
using QuickWay.Application.SalaryStatisticsUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.Presenters
{
    public class SurveyStatisticsPresenter : IQueryResponse<List<GenderAverageDto>>, IQueryResponse<List<LevelAverageDto>>
    {
        public void Respond(List<GenderAverageDto> response)
        {
            ContentResult = response
                .ToDictionary(d => d.Gender, d => d.Value.ToString());
        }

        public void Respond(List<LevelAverageDto> response)
        {
            ContentResult = response
                .ToDictionary(d => d.Level, d => d.Value.ToString());
        }

        public Dictionary<string, string> ContentResult { get; set; }
    }
}
