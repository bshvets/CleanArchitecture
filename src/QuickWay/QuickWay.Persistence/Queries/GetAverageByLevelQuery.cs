using Dapper;
using QuickWay.Application;
using QuickWay.Application.SalaryStatisticsUseCases.Dto;
using QuickWay.Application.SalaryStatisticsUseCases.Queries;
using QuickWay.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Persistence.Queries
{
    public class GetAverageByLevelQuery : IGetAverageByLevelQuery
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        private readonly IAuditService _auditService;

        public GetAverageByLevelQuery(IConnectionStringProvider connectionStringProvider, IAuditService auditService)
        {
            _connectionStringProvider = connectionStringProvider;
            _auditService = auditService;
        }

        public async Task ExecuteAsync(IQueryResponse<List<LevelAverageDto>> queryResponse)
        {
            await _auditService.LogAccess(nameof(GetAverageByLevelQuery));

            using (var connection = new SqlConnection(_connectionStringProvider.GetConnectionString()))
            {
                var result = await connection.QueryAsync<LevelAverageDto>(
                      @"SELECT D.[Level], AVG(A.YearSalary) AS Value 
                        FROM SurveyAnswer A
	                        INNER JOIN Developer D ON D.DeveloperId = A.DeveloperId
                        GROUP BY D.[Level]
                        ORDER BY Value DESC");

                queryResponse.Respond(result.ToList());
            }
        }
    }
}
