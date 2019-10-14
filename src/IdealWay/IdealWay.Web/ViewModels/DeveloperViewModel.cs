using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.ViewModels
{
    public class DeveloperViewModel
    {
        public int Id { get; set; }
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }
        [DisplayName("Primary Language")]
        public string PrimaryLanguage { get; set; }
        public string Gender { get; set; }
        [DisplayName("Experience (In years)")]
        public int YearsOfExperience { get; set; }
        public string Level { get; set; }
    }
}
