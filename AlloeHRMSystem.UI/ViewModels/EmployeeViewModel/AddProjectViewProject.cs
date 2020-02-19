using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels
{
    public class AddProjectViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name="Project Name")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Start { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Finish { get; set; }
        [Display(Name = "Is Project Completed")]
        public string Completed { get; set; }
        public string JobPosition { get; set; }
        public int ProjectId { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
       
    }
}
