using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Application.SurveyAnswerUseCases.Commands
{
    public class AddSurveyResponseRequest
    {
        public string DeveloperId { get; set; }
        public bool Satisfied { get; set; }
        public int YearSalary { get; set; }
    }
}
