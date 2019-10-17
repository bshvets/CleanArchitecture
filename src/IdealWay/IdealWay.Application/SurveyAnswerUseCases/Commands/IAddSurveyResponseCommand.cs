using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdealWay.Application.SurveyAnswerUseCases.Commands
{
    public interface IAddSurveyResponseCommand
    {
        Task<int> Handle(AddSurveyResponseRequest request, CancellationToken cancellationToken);
    }
}
