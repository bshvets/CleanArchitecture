using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Application
{
    public interface IQueryResponse<T>
    {
        void Respond(T response);
    }
}
