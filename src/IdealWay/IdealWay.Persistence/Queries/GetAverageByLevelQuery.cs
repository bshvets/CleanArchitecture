using Dapper;
using IdealWay.Application;
using IdealWay.Application.SalaryStatisticsUseCases.Dto;
using IdealWay.Application.SalaryStatisticsUseCases.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Persistence.Queries
{
    public class GetAverageByLevelQuery : IGetAverageByLevelQuery
    {
        private readonly IConnectionStringProvider _connectionStringProvider;

        public GetAverageByLevelQuery(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        public async Task ExecuteAsync(IQueryResponse<List<LevelAverageDto>> queryResponse)
        {
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
