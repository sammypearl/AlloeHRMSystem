using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels
{
    public class AddEducationViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        public string Department { get; set; }
        public int DegreeId { get; set; }
        [Required]
        [Display(Name ="Name of Degree")]
        public string Degree { get; set; }
        [Required]
        public string Institution { get; set; }
        
        [Required]
        public string StillStudying { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        [DataType(DataType.MultilineText)]
        public string Thesis { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? EntranceDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? GraduationDate { get; set; }
      
      
    }
}
