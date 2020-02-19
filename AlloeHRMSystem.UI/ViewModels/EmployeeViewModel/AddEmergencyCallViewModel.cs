using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels
{
    public class AddEmergencyCallViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "SurName")]
        public string SurName { get; set; }
        [Required]
        public string RelationTo { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
