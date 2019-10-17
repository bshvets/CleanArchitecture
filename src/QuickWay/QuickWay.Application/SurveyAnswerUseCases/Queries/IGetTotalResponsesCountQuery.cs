using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.SurveyAnswerUseCases.Queries
{
    public interface IGetTotalResponsesCountQuery
    {
        Task ExecuteAsync(IQueryResponse<int> queryResponse);
    }
}
