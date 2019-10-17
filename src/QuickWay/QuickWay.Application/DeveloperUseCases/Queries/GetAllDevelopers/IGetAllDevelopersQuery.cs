using QuickWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.DeveloperUseCases.Queries.GetAllDevelopers
{
    public interface IGetAllDevelopersQuery
    {
        Task ExecuteAsync(IQueryResponse<List<DeveloperDto>> queryResponse);
    }
}
