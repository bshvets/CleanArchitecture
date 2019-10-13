using IdealWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using IdealWay.Application.Notifications;
using IdealWay.Infrastructure.Notifications;
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

            //Application commands

            //Infrastructure services
            service.AddTransient<INotificationService, EmailNotificationService>();
        }
    }
}
