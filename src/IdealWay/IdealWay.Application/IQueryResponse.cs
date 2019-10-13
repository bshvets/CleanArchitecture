using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Application
{
    public interface IQueryResponse<T>
    {
        void Respond(T response);
    }
}
