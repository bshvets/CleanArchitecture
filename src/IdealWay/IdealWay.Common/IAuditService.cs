using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Common
{
    public interface IAuditService
    {
        Task LogChange(object obj);
        Task LogAccess(string featureName);
    }
}
