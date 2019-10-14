using IdealWay.Application;
using IdealWay.Application.ProgrammingLanguageUseCases.Dto;
using IdealWay.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.Presenters
{
    public class ProgrammingLanguageListPresenter : IQueryResponse<List<ProgrammingLanguageDto>>
    {
        public void Respond(List<ProgrammingLanguageDto> response)
        {
            ContentResult = new ProgrammingLanguagesListViewModel()
            {
                Languages = response
                .Select(d =>
                    new ProgrammingLanguageViewModel()
                    {
                        Id = d.ProgrammingLanguageId,
                        IsStronglyTyped = d.IsStronglyTyped,
                        Name = d.Name
                    })
                .ToList()
            };
        }

        public ProgrammingLanguagesListViewModel ContentResult { get; private set; }
    }
}
