using System;
using System.Collections.Generic;
using System.Text;
using IdealWay.Domain.Entities;
using IdealWay.Domain.Enums;

namespace IdealWay.Domain.ValueObjects
{
    public static class DeveloperExtension
    {
        public static void MakeDeveloperGreat(this Developer developer)
        {
            developer.Level = AbilitonLevel.Architect;
        }
    }
}
