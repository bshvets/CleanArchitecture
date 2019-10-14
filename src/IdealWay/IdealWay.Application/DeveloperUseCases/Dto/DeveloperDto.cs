using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Application.DeveloperUseCases.Dto
{
    public class DeveloperDto
    {
        public int DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryLanguage { get; set; }
        public int YearsOfExperience { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
    }
}
