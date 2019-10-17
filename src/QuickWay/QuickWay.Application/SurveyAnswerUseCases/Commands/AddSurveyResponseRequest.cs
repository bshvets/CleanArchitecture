using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Application.SurveyAnswerUseCases.Commands
{
    public class AddSurveyResponseRequest
    {
        public int DeveloperId { get; internal set; }
        public bool Satisfied { get; internal set; }
        public int YearSalary { get; internal set; }
    }
}
