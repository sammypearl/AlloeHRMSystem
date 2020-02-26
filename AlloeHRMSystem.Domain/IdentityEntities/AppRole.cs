
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.Domain.IdentityEntities
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base()
        {

        }

        //  public int RoleId { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }



    }
}


//if (!roleManager.RoleExistsAsync
//("NormalUser").Result)
//    {
//        MyIdentityRole role = new MyIdentityRole();
//role.Name = "NormalUser";
//        role.Description = "Perform normal operations.";
//        IdentityResult roleResult = roleManager.
//        CreateAsync(role).Result;
//    }


//    if (!roleManager.RoleExistsAsync("User").Result)
//            {
//                IdentityRole role = new IdentityRole();
//role.Name = "User";
//                IdentityResult roleResult = roleManager.
//                CreateAsync(role).Result;
//            }