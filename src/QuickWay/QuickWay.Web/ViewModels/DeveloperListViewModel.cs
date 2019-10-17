using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.ViewModels
{
    public class DeveloperListViewModel
    {
        public int Count { get; set; }
        public List<DeveloperViewModel> Developers { get; set; }
    }
}
