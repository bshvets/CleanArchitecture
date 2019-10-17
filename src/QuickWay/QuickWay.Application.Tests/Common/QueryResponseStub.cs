using QuickWay.Application.DeveloperUseCases.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Application.Tests.Common
{
    class QueryResponseStub : IQueryResponse<List<DeveloperDto>>
    {
        public void Respond(List<DeveloperDto> response)
        {
            Response = response;
        }

        public List<DeveloperDto> Response {get; private set; }
    }
}
