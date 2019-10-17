using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Domain.Entities
{
    public class ProgrammingLanguage
    {
        public int ProgrammingLanguageId { get; set; }
        public string Name { get; set; }
        public bool IsStronglyTyped { get; set; }

        public ICollection<Developer> Developers { get; private set; } = new List<Developer>();
    }
}
