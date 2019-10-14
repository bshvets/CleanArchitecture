using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdealWay.Application.ProgrammingLanguageUseCases.Dto;
using IdealWay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdealWay.Application.ProgrammingLanguageUseCases.Queries
{
    public class GetMostUsedProgrammingLanguages : IGetMostUsedProgrammingLanguages
    {
        private readonly IDevSalaryDbContext _dbContext;

        public GetMostUsedProgrammingLanguages(IDevSalaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ExecuteAsync(IQueryResponse<List<ProgrammingLanguageDto>> queryResponse)
        {
            var response =  await _dbContext
                .GetAllNoCachingQuery<ProgrammingLanguage>()
                .Select(l => 
                    new ProgrammingLanguageDto() {
                        ProgrammingLanguageId = l.ProgrammingLanguageId,
                        Name = l.Name,
                        IsStronglyTyped = l.IsStronglyTyped
                    })
                .ToListAsync();

            queryResponse.Respond(response);
        }
    }
}
