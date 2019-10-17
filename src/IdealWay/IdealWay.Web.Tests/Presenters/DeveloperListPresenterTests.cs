using IdealWay.Application.DeveloperUseCases.Dto;
using IdealWay.Domain.Enums;
using IdealWay.Web.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace IdealWay.Web.Tests.Presenters
{
    public class DeveloperListPresenterTests
    {
        [Fact]
        public void DeveloperListPresenterTest()
        {
            var developerListPresenter = new DeveloperListPresenter();

            developerListPresenter.Respond(new List<DeveloperDto>()
            {
                new DeveloperDto() { DeveloperId = 1, FirstName = "John", LastName = "Doe", Gender = "Male", Level = "Intermid"},
                new DeveloperDto() { DeveloperId = 2, FirstName = "Jane", LastName = "Doe", Gender = "Femal", Level = "Senior"}
            });

            var result = developerListPresenter.ContentResult;

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(2, result.Developers.Count);
            Assert.Equal(1, result.Developers.First().Id);
            Assert.Equal("John Doe", result.Developers.First().DisplayName);
            Assert.Equal(2, result.Developers.Last().Id);
        }
    }
}
