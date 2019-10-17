using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Web.ViewModels
{
    public class SurveyAnswerViewModel
    {
        public List<SelectListItem> Developers { get; set; }
        [Required]
        [DisplayName("Select your name")]
        public string SelectedDeveloperId { get; set; }        
        [Required]
        [DisplayName("Are you satisfied with your salary?")]
        public bool IsSatisfied { get; set; }
        [Required]
        [Range(100, int.MaxValue, ErrorMessage = "Please enter valid annual compensation")]
        [DisplayName("Please enter your annual compensation")]
        public int AnnualSalary { get; set; }
    }
}
