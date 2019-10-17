using QuickWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using QuickWay.Application.Notifications;
using QuickWay.Application.ProgrammingLanguageUseCases.Queries;
using QuickWay.Application.SalaryStatisticsUseCases.Queries;
using QuickWay.Application.SurveyAnswerUseCases.Commands;
using QuickWay.Common;
using QuickWay.Infrastructure.Notifications;
using QuickWay.Persistence.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace QuickWay.WebSupport
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
            services.AddTransient<IAddSurveyResponseCommand, AddSurveyResponseCommand>();            

            //Application commands

            //Infrastructure services
            services.AddTransient<INotificationService, EmailNotificationService>();

            //Cross-cutting conserns
            services.AddTransient<IAuditService, AuditService>();
        }
    }
}
