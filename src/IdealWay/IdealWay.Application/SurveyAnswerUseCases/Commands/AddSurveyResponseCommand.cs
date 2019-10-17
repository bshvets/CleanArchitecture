using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IdealWay.Domain.Entities;

namespace IdealWay.Application.SurveyAnswerUseCases.Commands
{
    public class AddSurveyResponseCommand : IAddSurveyResponseCommand
    {
        private readonly IDevSalaryDbContext _dbContext;

        public AddSurveyResponseCommand(IDevSalaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(AddSurveyResponseRequest request, CancellationToken cancellationToken)
        {
            SurveyAnswer entity = new SurveyAnswer()
            {
                DeveloperId = Int32.Parse(request.DeveloperId),
                Satisfied = request.Satisfied,
                YearSalary = request.YearSalary
            };
            _dbContext.AddEntity<SurveyAnswer>(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.AnswerId;
        }
    }
}
