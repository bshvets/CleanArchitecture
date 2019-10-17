using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Application.Notifications;
using IdealWay.Application.ProgrammingLanguageUseCases.Queries;
using IdealWay.Application.SalaryStatisticsUseCases.Queries;
using IdealWay.Application.SurveyAnswerUseCases.Commands;
using IdealWay.Common;
using IdealWay.Infrastructure.Notifications;
using IdealWay.Persistence.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdealWay.WebSupport
{
    public static class ApplicationInitialization
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            //Application queries
            services.AddTransient<IGetAllDevelopersQuery, GetAllDevelopersQuery>();
            services.AddTransient<IGetMostUsedProgrammingLanguages, GetMostUsedProgrammingLanguages>();
            services.AddTransient<IGetAverageByGenderQuery, GetAverageByGenderQuery>();
            services.AddTransient<IGetAverageByLevelQuery, GetAverageByLevelQuery>();            

            //Application commands
            services.AddTransient<IAddSurveyResponseCommand, AddSurveyResponseCommand>();            

            //Infrastructure services
            services.AddTransient<INotificationService, EmailNotificationService>();

            //Cross-cutting conserns
            services.AddTransient<IAuditService, AuditService>();
        }
    }
}
