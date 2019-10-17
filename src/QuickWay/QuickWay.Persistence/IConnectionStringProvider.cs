using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Persistence
{
    public interface IConnectionStringProvider
    {
        string GetConnectionString();
    }
}
