﻿using Dapper;
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
    public class GetAverageByGenderQuery : IGetAverageByGenderQuery
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        private readonly IAuditService _auditService;

        public GetAverageByGenderQuery(IConnectionStringProvider connectionStringProvider, IAuditService auditService)
        {
            _connectionStringProvider = connectionStringProvider;
            _auditService = auditService;
        }

        public async Task ExecuteAsync(IQueryResponse<List<GenderAverageDto>> queryResponse)
        {
            await _auditService.LogAccess(nameof(GetAverageByGenderQuery));

            using (var connection = new SqlConnection(_connectionStringProvider.GetConnectionString()))
            {
                var result = await connection.QueryAsync<GenderAverageDto>(
                      @"SELECT D.Gender, AVG(A.YearSalary) AS Value 
                        FROM SurveyAnswer A
	                        INNER JOIN Developer D ON D.DeveloperId = A.DeveloperId
                        GROUP BY D.Gender
                        ORDER BY Value DESC");

                queryResponse.Respond(result.ToList());
            }
        }
    }
}
