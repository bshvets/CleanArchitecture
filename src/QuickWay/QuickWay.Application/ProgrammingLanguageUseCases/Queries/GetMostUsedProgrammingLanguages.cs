using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickWay.Application.ProgrammingLanguageUseCases.Dto;
using QuickWay.Common;
using QuickWay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace QuickWay.Application.ProgrammingLanguageUseCases.Queries
{
    public class GetMostUsedProgrammingLanguages : IGetMostUsedProgrammingLanguages
    {
        private readonly IDevSalaryDbContext _dbContext;
        private readonly IAuditService _auditService;

        public GetMostUsedProgrammingLanguages(IDevSalaryDbContext dbContext, IAuditService auditService)
        {
            _dbContext = dbContext;
            _auditService = auditService;
        }

        public async Task ExecuteAsync(IQueryResponse<List<ProgrammingLanguageDto>> queryResponse)
        {
            await _auditService.LogAccess(nameof(GetMostUsedProgrammingLanguages));

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
