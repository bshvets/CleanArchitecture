using QuickWay.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.Tests.Common
{
    internal class AuditServiceStub : IAuditService
    {
        public Task LogAccess(string featureName)
        {
            return Task.CompletedTask;
        }

        public Task LogChange(object obj)
        {
            return Task.CompletedTask;
        }
    }
}
