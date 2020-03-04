using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class HrEmployeeIndexViewModel
    {
        public int EmployeeId { get; set; }
      //  public string UserId { get; set; }
        
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        
        [Phone]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }
        public Dept? Department { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string MaritalStatus { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }

        
        public string CreatedBy { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
    }
}
