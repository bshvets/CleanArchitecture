using QuickWay.Application.ProgrammingLanguageUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.ProgrammingLanguageUseCases.Queries
{
    public interface IGetMostUsedProgrammingLanguages
    {
        Task ExecuteAsync(IQueryResponse<List<ProgrammingLanguageDto>> queryResponse);
    }
}
