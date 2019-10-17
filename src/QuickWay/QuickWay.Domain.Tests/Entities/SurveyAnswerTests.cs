using QuickWay.Domain.Entities;
using System;
using Xunit;

namespace QuickWay.Domain.Tests.Entities
{
    public class SurveyAnswerTests
    {
        [Fact]
        public void TestMonthPaymentConverter()
        {
            var surveyAnswer = new SurveyAnswer() { YearSalary = 120000 };

            Assert.Equal(10000, surveyAnswer.MonthlySalary());
        }

        [Fact]
        public void TestHourRateConverter()
        {
            var surveyAnswer = new SurveyAnswer() { YearSalary = 120000 };

            Assert.Equal(62, surveyAnswer.HourRate());
        }
    }
}
