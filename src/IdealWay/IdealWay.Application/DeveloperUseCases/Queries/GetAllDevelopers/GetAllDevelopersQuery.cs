using IdealWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdealWay.Domain.Entities;
using System.Linq;
using IdealWay.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers
{
    public class GetAllDevelopersQuery : IGetAllDevelopersQuery
    {
        private readonly IDevSalaryDbContext _dbContext;

        public GetAllDevelopersQuery(IDevSalaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ExecuteAsync(IQueryResponse<List<DeveloperDto>> queryResponse)
        {
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
