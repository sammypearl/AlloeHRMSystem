using AlloeHRMSystem.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.AdminViewModel
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
        public string Id { get; set; }
        
      //  public int? EmployeeId { get; set; }
       // public string UserId { get; set; }
       
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "UserName")]
       // [Remote(action: "IsUserNameInUse", controller: "Account")]
        public string UserName { get; set; }
      
        [EmailAddress]
        [Display(Name = "Email")]
      //  [Remote(action: "IsEmailInUse", controller: "Account")]
        //[ValidEmailDomain(allowedDomain: "google.com",
        //    ErrorMessage = "Email domain must be google.com")]
        public string Email { get; set; }
        
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
       
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
     
        [Display(Name = "LastName")]
        public string LastName { get; set; }
       
        public string CreatedBy { get; set; }
    
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
     
        public string ModifyBy { get; set; }
        
        public string Title { get; set; }
        
        public string MobileNo { get; set; }
        public string Language { get; set; }
        public string Company { get; set; }
        
        [Display(Name = "Employee Dept")]
        public Dept? Department { get; set; }
        
        public string JobTitle { get; set; }

        // public string FailedAttempt { get; set; }
        public string HomePhone { get; set; }
      
        [DataType(DataType.Date)]
        public DateTime? LastPasswordUpdate { get; set; }
       
      
        public bool PasswordExpirationEnable { get; set; }
        public bool CanMakeCall { get; set; }
        public List<string> Claims { get; set; }
        public List<string> Roles { get; set; }

    }
}
