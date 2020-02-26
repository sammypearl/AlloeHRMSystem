using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.Domain.IdentityEntities
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base()
        {

        }
        //  [Key]
        // public int UserId { get; set; }

      //  public int? EmployeeId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string Title { get; set; }
        public string MobileNo { get; set; }
        public string Language { get; set; }
        public string Company { get; set; }
        public Dept? Department { get; set; }
        public string JobTitle { get; set; }
        public string HomePhone { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? LastPasswordUpdate { get; set; }
        public bool PasswordExpirationEnable { get; set; }
        public bool CanMakeCall { get; set; }
       
       // public Employee Employee { get; set; }

    }
}
