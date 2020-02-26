using AlloeHRMSystem.Domain.Enums;
using AlloeHRMSystem.UI.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.AccountViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string UserId { get; set; }
      //  [Required]
      //  public int EmployeeId { get; set; }
        [Required]
        [ValidEmailDomain(allowedDomain: "samuel-ak.tech",
            ErrorMessage = "Email domain must be samuel-ak.tech")]
       // [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "UserName")]
       // [Remote(action: "IsUserNameInUse", controller: "Account")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
       // [Remote(action:"IsEmailInUse", controller:"Account")]
        [ValidEmailDomain(allowedDomain: "samuel-ak.tech",
            ErrorMessage = "Email domain must be samuel-ak.tech")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        [Required]
        public string ModifyBy { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string Language { get; set; }
        public string Company { get; set; }
        [Required]
        [Display(Name = "Employee Dept")]
        public Dept? Department { get; set; }
        [Required]
        public string JobTitle { get; set; }
        
       // public string FailedAttempt { get; set; }
        public string HomePhone { get; set; }
      
       
        [DataType(DataType.Date)]
        public DateTime? LastPasswordUpdate { get; set; }
       
        
        public bool PasswordExpirationEnable { get; set; }
        public bool CanMakeCall { get; set; }

    }
}
