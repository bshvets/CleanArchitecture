using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Persistence
{
    public interface IConnectionStringProvider
    {
        string GetConnectionString();
    }
}
