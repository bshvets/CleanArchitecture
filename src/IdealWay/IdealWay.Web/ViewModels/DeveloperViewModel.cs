using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.ViewModels
{
    public class DeveloperViewModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string PrimaryLanguage { get; set; }
        public string Gender { get; set; }
        public int YearsOfExperience { get; set; }
        public string Level { get; set; }
    }
}
