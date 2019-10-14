using IdealWay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Domain.Entities
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PrimaryLanguageId { get; set; }
        public int YearsOfExperience { get; set; }
        public AbilitonLevel Level { get; set; }
        public Gender Gender { get; set; }

        public ProgrammingLanguage PrimaryLanguage { get; set; }
        public ICollection<SurveyAnswer> Answers { get; private set; } = new List<SurveyAnswer>();
    }
}
