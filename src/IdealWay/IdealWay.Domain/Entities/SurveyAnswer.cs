using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Domain.Entities
{
    public class SurveyAnswer
    {
        public int AnswerId { get; set; }
        public int DeveloperId { get; set; }
        public int YearSalary { get; set; }
        public bool Satisfied { get; set; }

        public Developer Developer { get; set; }

        public int MonthlySalary()
        {
            return YearSalary / 12;
        }

        public int HourRate()
        {
            return MonthlySalary() / 160;
        }
    }
}
