using AlloeHRMSystem.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class HrCreateViewModel
    {
        public int EmployeeId { get; set; }
        
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
        public string BloodType { get; set; }
        public string MaritalStatus { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        public string HousePhone { get; set; }
        public string ContractType { get; set; }
        public string JobLocation { get; set; }
        [Display(Name = "Employment Confirmation")]
        public bool IsConfirmed { get; set; }
      
        public string CreatedBy { get; set; }
     
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
       
        [DataType(DataType.Date)]
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? QuitDate { get; set; }
        public bool IsLeavedJob { get; set; }
        [DataType(DataType.Date)]
        public DateTime? LeaveJobDate { get; set; }
        public string LeaveJobReason { get; set; }
        public string LegalDayOff { get; set; }
        public IFormFile Photo { get; set; }
    }
}
