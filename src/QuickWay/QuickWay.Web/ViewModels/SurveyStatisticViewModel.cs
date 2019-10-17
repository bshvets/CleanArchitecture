using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.ViewModels
{
    public class SurveyStatisticViewModel
    {
        public bool? AverageByLevel { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}
