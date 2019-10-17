using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Common
{
    public interface IAuditService
    {
        Task LogChange(object obj);
        Task LogAccess(string featureName);
    }
}
