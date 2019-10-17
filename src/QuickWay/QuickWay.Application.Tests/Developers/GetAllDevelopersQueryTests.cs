using QuickWay.Application.DeveloperUseCases.Queries.GetAllDevelopers;
using QuickWay.Application.Tests.Common;
using QuickWay.Common;
using System;
using System.Threading.Tasks;
using Xunit;

namespace QuickWay.Application.Tests.Developers
{
    public class GetAllDevelopersQueryTests
    {
        private IDevSalaryDbContext dbContext;
        private IAuditService auditService;

        public GetAllDevelopersQueryTests()
        {
            dbContext = DevSalaryDbContextFactory.Create();
            auditService = new AuditServiceStub();    
        }

        [Fact]
        public async Task Test1()
        {
            var query = new GetAllDevelopersQuery(dbContext, auditService);
            var responseHandler = new QueryResponseStub();
            await query.ExecuteAsync(responseHandler);

            Assert.NotNull(responseHandler.Response);
            Assert.True(responseHandler.Response.Count > 0);
        }
    }
}
