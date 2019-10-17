﻿using QuickWay.Application.SalaryStatisticsUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.SalaryStatisticsUseCases.Queries
{
    public interface IGetAverageByGenderQuery
    {
        Task ExecuteAsync(IQueryResponse<List<GenderAverageDto>> queryResponse);
    }
}
