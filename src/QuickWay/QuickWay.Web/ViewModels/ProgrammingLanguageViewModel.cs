using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.ViewModels
{
    public class ProgrammingLanguageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Strongly Typed")]
        public bool IsStronglyTyped { get; set; }
    }
}
