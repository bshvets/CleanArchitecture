using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.Presenters
{
    public static class PresentersInitialization
    {
        public static void AddPresenters(this IServiceCollection services)
        {
            services.AddTransient<DeveloperListPresenter>();
            services.AddTransient<ProgrammingLanguageListPresenter>();
            services.AddTransient<SurveyAnswerPresenter>();
            services.AddTransient<SurveyStatisticsPresenter>();
        }
    }
}
