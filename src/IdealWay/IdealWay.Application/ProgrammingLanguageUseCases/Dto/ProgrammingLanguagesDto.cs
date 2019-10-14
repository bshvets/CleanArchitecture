using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Application.ProgrammingLanguageUseCases.Dto
{
    public class ProgrammingLanguageDto
    {
        public int ProgrammingLanguageId { get; set; }
        public string Name { get; set; }
        public bool IsStronglyTyped { get; set; }
    }
}
