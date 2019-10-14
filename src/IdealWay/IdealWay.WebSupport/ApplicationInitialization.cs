using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Application.Notifications;
using IdealWay.Application.ProgrammingLanguageUseCases.Queries;
using IdealWay.Application.SalaryStatisticsUseCases.Queries;
using IdealWay.Application.SurveyAnswerUseCases.Commands;
using IdealWay.Infrastructure.Notifications;
using IdealWay.Persistence.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdealWay.WebSupport
{
    public static class ApplicationInitialization
    {
        public static void AddApplicationServices(this IServiceCollection service)
        {
            //Application queries
            service.AddTransient<IGetAllDevelopersQuery, GetAllDevelopersQuery>();
            service.AddTransient<IGetMostUsedProgrammingLanguages, GetMostUsedProgrammingLanguages>();
            service.AddTransient<IGetAverageByGenderQuery, GetAverageByGenderQuery>();
            service.AddTransient<IGetAverageByLevelQuery, GetAverageByLevelQuery>();
            service.AddTransient<IAddSurveyResponseCommand, AddSurveyResponseCommand>();

            //Application commands

            //Infrastructure services
            service.AddTransient<INotificationService, EmailNotificationService>();
        }
    }
}
