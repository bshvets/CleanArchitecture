using IdealWay.Application;
using IdealWay.Application.SalaryStatisticsUseCases.Dto;
using IdealWay.Application.SalaryStatisticsUseCases.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Persistence.Queries
{
    public class GetAverageByGenderQuery : IGetAverageByGenderQuery
    {
        public Task ExecuteAsync(IQueryResponse<List<GenderAverageDto>> queryResponse)
        {
            throw new NotImplementedException();
        }
    }
}
