using IdealWay.Application.ProgrammingLanguageUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Application.ProgrammingLanguageUseCases.Queries
{
    public interface IGetMostUsedProgrammingLanguages
    {
        Task ExecuteAsync(IQueryResponse<List<ProgrammingLanguageDto>> queryResponse);
    }
}
