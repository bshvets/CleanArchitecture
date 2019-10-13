using IdealWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers
{
    public interface IGetAllDevelopersQuery
    {
        Task ExecuteAsync(IQueryResponse<List<DeveloperDto>> queryResponse);
    }
}
