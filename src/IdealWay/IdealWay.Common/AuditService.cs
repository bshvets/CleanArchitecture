using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Common
{
    public class AuditService : IAuditService
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
