using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class AddTrainingViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name = "Training Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Training Location")]
        public string Location { get; set; }
        [Required]
        [DataType(DataType.Duration)]
        public string Duration { get; set; }
        [Required]
        [Display(Name = "Training Provider")]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? Start { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? Finish { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
