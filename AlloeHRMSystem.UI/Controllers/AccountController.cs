using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlloeHRMSystem.Domain.IdentityEntities;
using AlloeHRMSystem.UI.ViewModels.AccountViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlloeHRMSystem.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ILogger logger;
       // private readonly IEmailSender emailSender;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, 
            ILogger<AccountController> logger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
           // this.emailSender = emailSender;
           
        }
        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Home", "Index");
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                  
                var result = await signInManager.PasswordSignInAsync(model.UserName, 
                    model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    logger.LogInformation("User logged in successful");
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("HomeIndex", "Home");
                    }
                   // return RedirectToAction("HomeIndex", "Home");
                }
             
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
             
            }

            return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsUserNameInUse(string username)
        {
            var user = userManager.FindByNameAsync(username);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {username} is already in use");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                  //  EmployeeId = model.EmployeeId,
                  //  UserId = model.UserId,
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Title = model.Title,
                    MobileNo = model.MobileNo,
                    Language = model.Language,
                    Company = model.Company,
                    Department = model.Department,
                    JobTitle = model.JobTitle,
                    HomePhone = model.HomePhone,
                    CreatedBy = model.CreatedBy,
                    CreateDate = model.CreateDate,
                    ModifyBy = model.ModifyBy,
                    LastPasswordUpdate = model.LastPasswordUpdate,
                    PasswordExpirationEnable = model.PasswordExpirationEnable,
                    CanMakeCall = model.CanMakeCall
                };
                var result = await userManager.CreateAsync(user, model.Password);
                
                if(result.Succeeded)
                {
                    logger.LogInformation("User created a new account with password.");
                    // For future use if if more roles are added
                    if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Admin");
                    }

                    await signInManager.SignInAsync(user, isPersistent: false);

                    logger.LogInformation("User created a new account with password.");
                    return RedirectToAction("Index", "Admin");
                }
                foreach (var errors in result.Errors)
                {
                    ModelState.AddModelError("", errors.Description);
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "Home");
        }

       
    }
}