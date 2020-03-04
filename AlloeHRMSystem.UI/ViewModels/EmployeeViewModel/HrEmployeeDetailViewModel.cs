using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class HrEmployeeDetailViewModel
    {
        public int EmployeeId { get; set; }
       // public string UserId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }
        public Dept? Department { get; set; }
        public string City { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string MaritalStatus { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }

        [Required]
        public string CreatedBy { get; set; }
    }
}
