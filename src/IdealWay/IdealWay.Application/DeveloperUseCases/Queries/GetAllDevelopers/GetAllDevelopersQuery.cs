using IdealWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdealWay.Domain.Entities;
using System.Linq;
using IdealWay.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using IdealWay.Common;

namespace IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers
{
    public class GetAllDevelopersQuery : IGetAllDevelopersQuery
    {
        private readonly IDevSalaryDbContext _dbContext;
        private readonly IAuditService _auditService;

        public GetAllDevelopersQuery(IDevSalaryDbContext dbContext, IAuditService auditService)
        {
            _dbContext = dbContext;
            _auditService = auditService;
        }

        public async Task ExecuteAsync(IQueryResponse<List<DeveloperDto>> queryResponse)
        {
            await _auditService.LogAccess(nameof(GetAllDevelopersQuery));

            var developers = await _dbContext
                .GetAllQuery<Developer>()
                .Include(d => d.PrimaryLanguage)
                .ToListAsync();

            var response = developers
                .Select(d =>
                    new DeveloperDto()
                    {
                        DeveloperId = d.DeveloperId,
                        FirstName = d.FirstName,
                        LastName = d.LastName,
                        Gender = Enum.GetName(typeof(Gender), d.Gender),
                        Level = Enum.GetName(typeof(AbilitonLevel), d.Level),
                        PrimaryLanguage = d.PrimaryLanguage.Name,
                        YearsOfExperience = d.YearsOfExperience
                    })
                .ToList();

            queryResponse.Respond(response);            
        }
    }
}
