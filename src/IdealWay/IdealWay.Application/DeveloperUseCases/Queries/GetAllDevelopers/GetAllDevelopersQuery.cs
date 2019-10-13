using IdealWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IdealWay.Domain.Entities;
using System.Linq;
using IdealWay.Domain.Enums;

namespace IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers
{
    public class GetAllDevelopersQuery : IGetAllDevelopersQuery
    {
        public Task ExecuteAsync(IQueryResponse<List<DeveloperDto>> queryResponse)
        {
            var developers = new List<Developer>()
            {
                new Developer() {
                    DeveloperId = 1,
                    FirstName = "Jacques",
                    LastName = "Chirac",
                    Gender = Gender.Male,
                    PrimaryLanguageId = 1,
                    YearsOfExperience = 23,
                    Level = AbilitonLevel.SeniorPro
                },
                new Developer() {
                    DeveloperId = 2,
                    FirstName = "Monica",
                    LastName = "Bellucci",
                    Gender = Gender.Female,
                    PrimaryLanguageId = 2,
                    YearsOfExperience = 12,
                    Level = AbilitonLevel.Indermediate
                }
            };

            var response = developers
                .Select(d =>
                    new DeveloperDto()
                    {
                        DeveloperId = d.DeveloperId,
                        FirstName = d.FirstName,
                        LastName = d.LastName,
                        Gender = Enum.GetName(typeof(Gender), d.Gender),
                        PrimaryLanguage = d.PrimaryLanguage.Name,
                        YearsOfExperience = d.YearsOfExperience
                    })
                .ToList();

            queryResponse.Respond(response);
            return Task.CompletedTask;
        }
    }
}
