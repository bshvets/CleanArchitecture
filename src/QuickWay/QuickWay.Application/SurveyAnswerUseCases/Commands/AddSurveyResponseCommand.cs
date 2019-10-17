using QuickWay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickWay.Application.SurveyAnswerUseCases.Commands
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
                DeveloperId = request.DeveloperId,
                Satisfied = request.Satisfied,
                YearSalary = request.YearSalary
            };
            _dbContext.AddEntity<SurveyAnswer>(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.AnswerId;
        }
    }
}
