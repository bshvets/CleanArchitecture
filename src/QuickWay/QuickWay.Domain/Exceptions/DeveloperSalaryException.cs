using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace QuickWay.Domain.Exceptions
{
    public class DeveloperSalaryException : Exception
    {
        public DeveloperSalaryException()
        {
        }

        public DeveloperSalaryException(string message) : base(message)
        {
        }

        public DeveloperSalaryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeveloperSalaryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
