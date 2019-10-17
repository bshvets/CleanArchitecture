using QuickWay.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.SurveyAnswerUseCases.Queries
{
    public class GetTotalResponsesCountQuery : IGetTotalResponsesCountQuery
    {
        private readonly IDevSalaryDbContext _dbContext;
        private readonly IAuditService _auditService;

        public GetTotalResponsesCountQuery(IDevSalaryDbContext dbContext, IAuditService auditService)
        {
            _dbContext = dbContext;
            _auditService = auditService;
        }

        public async Task ExecuteAsync(IQueryResponse<int> queryResponse)
        {
            await _auditService.LogAccess(nameof(GetTotalResponsesCountQuery));
            throw new NotImplementedException();
        }
    }
}
