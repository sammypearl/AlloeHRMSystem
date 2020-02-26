using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Domain.Enums;
using AlloeHRMSystem.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace AlloeHRMSystem.Persistence
{
    public class AlloeHRMSystemInitializers
    {
       
        private readonly Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
        private readonly Dictionary<int, EmployeeAttachment> EmployeeAttachments = new Dictionary<int, EmployeeAttachment>();
        private readonly Dictionary<int, EmployeeCertificate> EmployeeCertificates = new Dictionary<int, EmployeeCertificate>();
        private readonly Dictionary<int, EmployeeEducation> EmployeeEducations = new Dictionary<int, EmployeeEducation>();
        private readonly Dictionary<int, EmployeeEmergencyCall> EmployeeEmergencyCalls = new Dictionary<int, EmployeeEmergencyCall>();
        private readonly Dictionary<int, EmployeeLanguage> EmployeeLanguages = new Dictionary<int, EmployeeLanguage>();
        private readonly Dictionary<int, EmployeeProject> EmployeeProjects = new Dictionary<int, EmployeeProject>();
        private readonly Dictionary<int, EmployeeQuit> EmployeeQuits = new Dictionary<int, EmployeeQuit>();
        private readonly Dictionary<int, EmployeeTechnicalSkill> EmployeeTechnicalSkills = new Dictionary<int, EmployeeTechnicalSkill>();
        private readonly Dictionary<int, EmployeeTraining> EmployeeTrainings = new Dictionary<int, EmployeeTraining>();

        public static void Initialize(AlloeContext context,
             UserManager<AppUser> userManager, RoleManager<AppRole> roleManager
             )
        {
            var initializer = new AlloeHRMSystemInitializers();
            initializer.SeedEverything(context, userManager, roleManager);
        }
        public void SeedEverything(AlloeContext context,
            UserManager<AppUser> userManager, RoleManager<AppRole> roleManager
             )
        {
         
              context.Database.EnsureCreated();

                if (!context.AppRoles.Any())
                {
                    SeedAppRoles(roleManager).GetAwaiter().GetResult(); // Database has been seeded
                }

            if (!context.AppUsers.Any())
            {
                SeedAppUsers(userManager).GetAwaiter().GetResult(); // Database has been seeded

            }

            if (!context.Employees.Any())
                {
                SeedEmployees(context); // Database has been seeded
                }

                if (!context.EmployeeAttachments.Any())
                {
                    SeedEmployAttachment(context); // Database has been seeded
                }

                if (!context.EmployeeCertificates.Any())
                {
                    SeedEmployCertificates(context); // Database has been seeded
                }

                if (!context.EmployeeEducations.Any())
                {
                    SeedEmployEducations(context); // Database has been seeded
                }

                if (!context.EmployeeEmergencyCalls.Any())
                {
                    SeedEmployEmergencyCall(context); // Database has been seeded
                }

                if (!context.EmployeeLanguages.Any())
                {
                    SeedEmploLanguages(context); // Database has been seeded
                }

                if (!context.EmployeeProjects.Any())
                {
                    SeedEmployProjects(context); // Database has been seeded
                }

                if (!context.EmployeeQuits.Any())
                {
                    SeedEmployQuits(context); // Database has been seeded
                }

                if (!context.EmployeeTechnicalSkills.Any())
                {
                    SeedEmployTechSkills(context); // Database has been seeded
                }

                if (!context.EmployeeTrainings.Any())
                {
                    SeedEmployTrainings(context); // Database has been seeded
                }
            
          
        }

        

        public static async Task SeedAppUsers(UserManager<AppUser> userManager)
        {
            var MyEmailAddress = "sammy1@samuel-ak.tech";
            var MyPassword = "Sammyk_@001";
            if (await userManager.FindByNameAsync(MyEmailAddress) == null)
            {
                var appUsers = new AppUser
                {
                   // EmployeeId = 1,
                    UserId = "001",
                    UserName = MyEmailAddress,
                    Email = MyEmailAddress,
                    // Password = MyPassword,
                    FirstName = "Samuel",
                    LastName = "Gates",
                    Title = "Mr",
                    MobileNo = "+2348062623445",
                    Language = "English",
                    Company = "Google Inc",
                    Department = Dept.Admin,
                    JobTitle = "Software Engineer",
                    HomePhone = "+2348074766622",
                    CreatedBy = "Sammy Lee",
                    CreateDate = DateTime.Parse("Feb 20 2018"),
                    ModifyBy = "Lennon Lewwis",
                    LastPasswordUpdate = DateTime.Parse("May 11 2013"),
                    PasswordExpirationEnable = true,
                    CanMakeCall = true,
                };
                IdentityResult result = await userManager.CreateAsync(appUsers);
                if (result.Succeeded)
                {
                   await userManager.AddPasswordAsync(appUsers, MyPassword);
                   await  userManager.AddToRoleAsync(appUsers, "Admin");
                    
                }
            }

            var MyEmailAddress2 = "sammy2@samuel-ak.tech";
            var MyPassword2 = "Sammyk_@002";
            if (await userManager.FindByNameAsync(MyEmailAddress2) == null)
            {

                var appUsers = new AppUser
                {
                   // EmployeeId = 2,
                    UserId = "002",
                    UserName = MyEmailAddress2,
                    Email = MyEmailAddress2,
                    FirstName = "Samuel",
                    LastName = "Akinsoju",
                    Title = "Mr",
                    MobileNo = "+2348062623445",
                    Language = "English",
                    Company = "Google Inc",
                    Department = Dept.HR,
                    JobTitle = "Network Engineer",
                    HomePhone = "+2348074766622",
                    CreatedBy = "Steve Bannon",
                    CreateDate = DateTime.Parse("Feb 20 2018"),
                    ModifyBy = "Lennon Lewwis",
                    LastPasswordUpdate = DateTime.Parse("May 11 2014 11:30AM"),
                    PasswordExpirationEnable = true,
                    CanMakeCall = true,
                };

                IdentityResult result = await userManager.CreateAsync(appUsers);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(appUsers, MyPassword2);
                   await  userManager.AddToRoleAsync(appUsers, "HR");
                }

            }

            var MyEmailAddress3 = "sammy3@samuel-ak.tech";
            var MyPassword3 = "Sammyk_@003";
            if (await userManager.FindByNameAsync(MyEmailAddress3) == null)
            {
                var appUsers = new AppUser
                {
                   // EmployeeId = 3,
                    UserId = "003",
                    UserName = MyEmailAddress3,
                    Email = MyEmailAddress3,
                    FirstName = "Sammy Achillis",
                    LastName = "Achillis",
                    Title = "Dr",
                    MobileNo = "+2348062623445",
                    Language = "English",
                    Company = "Apple Inc",
                    Department = Dept.IT,
                    JobTitle = "IT Security Engineer",
                    HomePhone = "+2348074766622",
                    CreatedBy = "Sammy Arthur",
                    CreateDate = DateTime.Parse("Feb 20 2018"),
                    ModifyBy = "Lennon Lewwis",
                    LastPasswordUpdate = DateTime.Parse("May 11 2014"),
                    PasswordExpirationEnable = true,
                    CanMakeCall = true,
                };

                IdentityResult result = await userManager.CreateAsync(appUsers);
                if (result.Succeeded)
                {
                   await   userManager.AddPasswordAsync(appUsers, MyPassword3);
                   await  userManager.AddToRoleAsync(appUsers, "Manager");
                }
            }

        }
        public static async Task SeedAppRoles(RoleManager<AppRole> roleManager)
        {
            if ( !roleManager.RoleExistsAsync("Admin").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Admin";
                role.Description = "Responsible for creating new AppUsers";
                role.CreatedBy = "Samuel";
                role.CreateDate = DateTime.Parse("May 11 2014");
                role.ModifiedBy = "Samuel";
                role.ModifiedDate = DateTime.Parse("May 11 2014");
                IdentityResult roleResult = await roleManager.CreateAsync(role);
            }

            if ( !roleManager.RoleExistsAsync("HR").Result)
            {
                AppRole role = new AppRole();
                role.Name = "HR";
                role.Description = "Responsible for creating new Employee";
                role.CreatedBy = "Gary";
                role.CreateDate = DateTime.Parse("Feb 24 2015");
                role.ModifiedBy = "Gary";
                role.ModifiedDate = DateTime.Parse("May 17 2017");
                IdentityResult roleResult = await roleManager.CreateAsync(role);
            }

            if (!roleManager.RoleExistsAsync("Manager").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Manager";
                role.Description = "Responsible for Assigning Roles Managing All AppUsers in its Dept";
                role.CreatedBy = "Trump";
                role.CreateDate = DateTime.Parse("May 21 2012");
                role.ModifiedBy = "Trump";
                role.ModifiedDate = DateTime.Parse("Feb 20 2013");
                IdentityResult roleResult = await roleManager.CreateAsync(role);
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Employee";
                role.Description = "Normal Role for Every AppUsers";
                role.CreatedBy = "Bill";
                role.CreateDate = DateTime.Parse("Oct 23 2014");
                role.ModifiedBy = "Bill";
                role.ModifiedDate = DateTime.Parse("May 12 2015");
                IdentityResult roleResult = await roleManager.CreateAsync(role);
            }
        }
        public void SeedEmployees(AlloeContext context)
        {
           // using (var transaction = context.Database.BeginTransaction())
           // {
                Employees.Add(1,
                    //var employees = new[] {
                    // context.Employees.AddRange(

                    new Employee
                    {
                        EmployeeId = 1,
                        // UserId = "001",
                        Firstname = "Samuel",
                        Lastname = "Akinsoju",
                        Phone = "+2348062623445",
                        Email = "sammy1@samuel-ak.tech",
                        HomeAddress = "5, Sesame street NYC",
                        Department = Dept.HR,
                        City = "Lagos",
                        Country = "Nigeria",
                        JobTitle = "IT Support Engineer",
                        Rank = "IT Head",
                        BloodType = "B+",
                        MaritalStatus = "Single",
                        DateOfBirth = DateTime.Parse("Jan 26 1987 12:00AM"),
                        Gender = "Male",
                        PhotoPath = "~/images/noimage.jpg",
                        Nationality = "Nigerian",
                        HousePhone = "+2349088844433",
                        ContractType = "ShortTerm",
                        JobLocation = "Lagos",
                        IsConfirmed = true,

                        CreatedBy = "Steven Arthur",
                        CreateDate = DateTime.Parse("Feb 20 2018"),
                        LastModifiedBy = "Lennon Lewwis",
                        StartDate = DateTime.Parse("Mar 23 2011"),
                        QuitDate = DateTime.Parse("Mar 23 2011"),

                        IsLeavedJob = false,
                        LeaveJobDate = DateTime.Parse("Jan 22 2019"),
                        LeaveJobReason = "Not getting enough vacation",


                        LegalDayOff = "9"


                    });

                Employees.Add(2,
                  new Employee
                  {
                      EmployeeId = 2,
                  //  UserId = "002",
                  Firstname = "Samuel",
                      Lastname = "Stacey",
                      Phone = "+2348062623445",
                      Email = "sammy2@samuel-ak.tech",
                      HomeAddress = "6, Sesame street NYC",
                      Department = Dept.IT,
                      City = "Prague",
                      Country = "Slovekia",
                      JobTitle = "Software Engineer",
                      Rank = "Senior Software Engineer",
                      BloodType = "B+",
                      MaritalStatus = "Married",
                      DateOfBirth = DateTime.Parse("Jan 26 1984"),
                      Gender = "Male",
                      PhotoPath = "~/images/noimage.jpg",
                      Nationality = "British",
                      HousePhone = "+2349088844433",
                      ContractType = "ShortTerm",
                      JobLocation = "USA",
                      IsConfirmed = true,
                      CreatedBy = "Sammy Arthur",
                      CreateDate = DateTime.Parse("Feb 20 2018"),
                      LastModifiedBy = "Lennon Lewwis",
                      StartDate = DateTime.Parse("Mar 23 2012"),
                      QuitDate = DateTime.Parse("Mar 23 2019"),
                      IsLeavedJob = false,
                      LeaveJobDate = DateTime.Parse("Aug 22 2019"),
                      LeaveJobReason = "Not getting enough vacation",
                      LegalDayOff = "32"

                  });

                Employees.Add(3,
                        new Employee
                        {
                            EmployeeId = 3,
                        //  UserId = "003",
                        Firstname = "Samuel",
                            Lastname = "Arthur",
                            Phone = "+2348062623445",
                            Email = "sammy3@samuel-ak.tech",
                            HomeAddress = "7, Sesame street NYC",
                            Department = Dept.Admin,
                            City = "Budapest",
                            Country = "Romania",
                            JobTitle = "Software Developer",
                            Rank = "Project Lead",
                            BloodType = "B+",
                            MaritalStatus = "Single",
                            DateOfBirth = DateTime.Parse("Jan 26 1987"),
                            Gender = "Female",
                            PhotoPath = "~/images/noimage.jpg",
                            Nationality = "British",
                            HousePhone = "+2349088844433",
                            ContractType = "ShortTerm",
                            JobLocation = "Britain",
                            IsConfirmed = true,
                            CreateDate = DateTime.Parse("Feb 20 2018"),
                            LastModifiedBy = "Lennon Lewwis",
                            CreatedBy = "Sammy Arthur",
                            StartDate = DateTime.Parse("Mar 23 2012"),
                            QuitDate = DateTime.Parse("Sep 23 2014"),
                            IsLeavedJob = false,
                            LeaveJobDate = DateTime.Parse("Nov 22 2019"),
                            LeaveJobReason = "Not getting enough vacation",
                            LegalDayOff = "22"
                        });


                foreach (var employee in Employees.Values)
                {
                    context.Employees.Add(employee);
                }
                 // context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Employee] ON");

                context.SaveChangesAsync();

               // context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Employee] OFF");
               // transaction.Commit();
                // );
                // context.Employees.AddRange(employees);
                //await context.SaveChangesAsync();
                //  context.Database.BeginTransaction()
          //  }
        }

        public void SeedEmployAttachment(AlloeContext context)
        {
            EmployeeAttachments.Add(1,
           // var employatt = new[] {
          //  context.EmployeeAttachments.AddRange
           // (
               new EmployeeAttachment
               {
                   FileName = "Degree Certificate",
                   EmployeeId = 1,
                   FileId = 2,
                   URLOnly = "www.samuel-ak.tech",
                   Notes = "My bachelor degree certificate",
                   FileSize = 20,

                   Type = FileType.Excel,
               });
            EmployeeAttachments.Add(2,
                new EmployeeAttachment
                {
                    FileName = "Degree Certificate",
                    EmployeeId = 1,
                    FileId = 2,
                    URLOnly = "www.samuel-ak.tech",
                    Notes = "My bachelor degree certificate",
                    FileSize = 20,

                    Type = FileType.Excel,
                });
            EmployeeAttachments.Add(3,
                 new EmployeeAttachment
                 {
                     FileName = "Diploma Certificate",
                     EmployeeId = 2,
                     FileId = 2,
                     URLOnly = "www.samuel-ak.tech",
                     Notes = "My bachelor degree certificate",
                     FileSize = 20,

                     Type = FileType.Excel,
                 });
            EmployeeAttachments.Add(4,
               new EmployeeAttachment
               {
                   FileName = "High School Certificate",
                   EmployeeId = 2,
                   FileId = 3,
                   URLOnly = "www.samuel-ak.tech",
                   Notes = "My bachelor degree certificate",
                   FileSize = 20,

                   Type = FileType.Picture,


               });

            EmployeeAttachments.Add(5,
               new EmployeeAttachment
               {
                   FileName = "Resume Document",
                   EmployeeId = 3,
                   FileId = 4,
                   URLOnly = "www.samuel-ak.tech",
                   Notes = "My bachelor degree certificate",
                   FileSize = 20,

                   Type = FileType.Pdf,

               });
           //);
            foreach (var employAttac in EmployeeAttachments.Values)
            {
                context.EmployeeAttachments.Add(employAttac);
            }
          //  context.EmployeeAttachments.AddRange(employatt);
           context.SaveChangesAsync();

        }




        public void SeedEmployCertificates(AlloeContext context)
        {
            EmployeeCertificates.Add(1,
           // var employcert = new[] {
           // context.EmployeeCertificates.AddRange(

                new EmployeeCertificate
                {
                    EmployeeId = 1,
                    Name = "Certified Ethical Hacker",
                    Provider = "EC Counsil",
                    // EmployeeId = 1,
                    
                    Date = DateTime.Parse("Aug 15 2019"),
                    Notes = "Certificate issued for passing CEH Exam",

                });

            EmployeeCertificates.Add(2,
               new EmployeeCertificate
               {
                   EmployeeId = 2,
                   Name = "Certified Ethical Hacker",
                   Provider = "EC Counsil",
                   //  EmployeeId = 2,

                   Date = DateTime.Parse("Aug 15 2019"),
                   Notes = "Certificate issued for passing CEH Exam",

               });

            EmployeeCertificates.Add(3,
               new EmployeeCertificate
               {
                   EmployeeId = 3,
                   Name = "Certified Ethical Hacker",
                   Provider = "EC Counsil",
                   // EmployeeId = 3,

                   Date = DateTime.Parse("Aug 15 2019"),
                   Notes = "Certificate issued for passing CEH Exam",

               });

           // );
            foreach (var employCert in EmployeeCertificates.Values)
            {
                context.EmployeeCertificates.Add(employCert);
            }
           // context.EmployeeCertificates.AddRange(employcert);
            context.SaveChangesAsync();
        }



        public void SeedEmployEducations(AlloeContext context)
        {
            EmployeeEducations.Add(1,
           // var employed = new[] {
           // context.EmployeeEducations.AddRange(

                new EmployeeEducation
                {
                    EmployeeId = 1,
                    Department = "Computer Engineering",
                    DegreeId = 1,
                    Degree = "MBA in Information Technology",
                    Institution = "Preston University USA",
                    StillStudying = "No",

                    Notes = "Finish my MBA in PRESTON University USA ",
                    Thesis = "Driving a startup to middle scale enterprise in the USA",
                    EntranceDate = DateTime.Parse("Feb 22 2012"),
                    GraduationDate = DateTime.Parse("Jan 20 2017"),



                });

            EmployeeEducations.Add(2,
                new EmployeeEducation
                {
                    EmployeeId = 2,
                    Department = "Business Administration",
                    DegreeId = 2,
                    Degree = "MBA in Information Technology",
                    Institution = "Preston University USA",
                    StillStudying = "No",

                    Notes = "Finish my MBA in PRESTON University USA ",
                    Thesis = "Driving a startup to middle scale enterprise in the USA",
                    EntranceDate = DateTime.Parse("Feb 22 2013"),
                    GraduationDate = DateTime.Parse("Jan 26 2017"),



                });

            EmployeeEducations.Add(3,
               new EmployeeEducation
               {
                   EmployeeId = 3,
                   Department = "Accounting",
                   DegreeId = 3,
                   Degree = "MBA in Information Technology",
                   Institution = "Preston University USA",
                   StillStudying = "No",

                   Notes = "Finish my MBA in PRESTON University USA ",
                   Thesis = "Driving a startup to middle scale enterprise in the USA",
                   EntranceDate = DateTime.Parse("Feb 22 2014"),
                   GraduationDate = DateTime.Parse("Jan 28 2017"),

               });

            //);
            foreach (var employEdu in EmployeeEducations.Values)
            {
                context.EmployeeEducations.Add(employEdu);
            }
           // context.EmployeeEducations.AddRange(employed);
            context.SaveChangesAsync();
        }

        public void SeedEmployEmergencyCall(AlloeContext context)
        {
            EmployeeEmergencyCalls.Add(1,
           // var employemer = new[] {
             // context.EmployeeEmergencyCalls.AddRange(
                 new EmployeeEmergencyCall
                 {
                     EmployeeId = 1,
                     Name = "Smuel Akinsosju",
                     SurName = "Akinsoju",
                     RelationTo = "MaCalley",
                     Phone = "+2348060050022"


                 });

            EmployeeEmergencyCalls.Add(2,
                new EmployeeEmergencyCall
                {
                    EmployeeId = 2,
                    Name = "Smuel Akinju",
                    SurName = "Akinju",
                    RelationTo = "MaCalley",
                    Phone = "+2348060050022"


                });

            EmployeeEmergencyCalls.Add(3,
                new EmployeeEmergencyCall
                {
                    EmployeeId = 3,
                    Name = "Smuel Akinsosju",
                    SurName = "Akins",
                    RelationTo = "MaCalley",
                    Phone = "+2348060050022"
                });
            // );
            foreach (var employEmerg in EmployeeEmergencyCalls.Values)
            {
                context.EmployeeEmergencyCalls.Add(employEmerg);
            }
           // context.EmployeeEmergencyCalls.AddRange(employemer);
           context.SaveChangesAsync();
        }

        public void SeedEmploLanguages(AlloeContext context)
        {
            EmployeeLanguages.Add(1,
           // var employlan = new[] {
             // context.EmployeeLanguages.AddRange(
                new EmployeeLanguage
                {
                    EmployeeId = 1,
                    Language = "Spanish",
                    WrittenLevel = Level.Beginner,
                    SpeakingLevel = Level.Intermediate,
                    NativeLang = "No",
                    LanguageId = 1,
                    Notes = "Can speak spanish on a professional level",


                });

            EmployeeLanguages.Add(2,
               new EmployeeLanguage
               {
                   EmployeeId = 2,
                   Language = "French",
                   WrittenLevel = Level.Advanced,
                   SpeakingLevel = Level.Intermediate,
                   NativeLang = "No",
                   LanguageId = 2,
                   Notes = "Can speak spanish on a professional level",
                   

               });

            EmployeeLanguages.Add(3,
               new EmployeeLanguage
               {
                   EmployeeId = 3,
                   Language = "Spanish",
                   WrittenLevel = Level.Beginner,
                   SpeakingLevel = Level.Intermediate,
                   NativeLang = "Yes",
                   LanguageId = 3,
                   Notes = "Can speak spanish on a professional level",

               });
          // );
            foreach (var employLang in EmployeeLanguages.Values)
            {
                context.EmployeeLanguages.Add(employLang);
            }
           // context.EmployeeLanguages.AddRange(employlan);
           context.SaveChangesAsync();
        }

        public void SeedEmployProjects(AlloeContext context)
        {
            EmployeeProjects.Add(1,
             // var employpro = new[] {
             //context.EmployeeProjects.AddRange(
                new EmployeeProject
                {
                    EmployeeId = 1,
                    Name = "Developing a complaints logging system",
                    Start = DateTime.Parse("Jan 12 2015"),
                    Finish = DateTime.Parse("Sept 20 2015"),
                    Completed = "Yes",
                    JobPosition = "Software Support",
                    ProjectId = 1,
                    Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",


                });

            EmployeeProjects.Add(2,
               new EmployeeProject
               {
                   EmployeeId = 2,
                   Name = "Developing a complaints logging system",
                   Start = DateTime.Parse("Jan 12 2015"),
                   Finish = DateTime.Parse("Sep 22 2015"),
                   Completed = "Yes",
                   JobPosition = "Software Developer",
                   ProjectId = 2,
                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",


               });

            EmployeeProjects.Add(3,
               new EmployeeProject
               {
                   EmployeeId = 3,
                   Name = "Developing a complaints logging system",
                   Start = DateTime.Parse("Jan 12 2015"),
                   Finish = DateTime.Parse("Sept 20 2015"),
                   Completed = "No",
                   JobPosition = "Software Engineer",
                   ProjectId = 3,
                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",

               });
          // );
            foreach (var emploPro in EmployeeProjects.Values)
            {
                context.EmployeeProjects.Add(emploPro);
            }
           // context.EmployeeProjects.AddRange(employpro);
             context.SaveChangesAsync();
        }

        public void SeedEmployQuits(AlloeContext context)
        {
            EmployeeQuits.Add(1,
             // var employqu = new[] {
             // context.EmployeeQuits.AddRange(
                 new EmployeeQuit
                 {
                     EmployeeId = 1,
                     ProcessBegin = DateTime.Parse("Jan 22 2018"),
                     ProcessEnd = DateTime.Parse("Dec 02 2017"),
                     ApproverId = 1,
                     CHRAdvance = "30 DAYS",
                     TrainingCancel = "Yes",
                     HealthInsurance = "Beneficiary",
                     CHRNotes = "Good and hardworking, he outperformed our expectation",
                     CompanyIdCard = "taking back",
                     PC = "Left in a good shape",
                     Monitor = "Left in a good condition",
                     PhoneHeadSet = "taking back",
                     CioNotes = "No fault was found in him",
                     CreditCard = "submitted",
                     GSMCard = "Submitted",
                     CompanyVehicle = "None",
                     VehicleEntryStamp = "none",
                     BookKeepingAdvance = "None",
                     BANotes = "All due process observed",
                     Multinet = "Subcription cutoff",
                     Quit = true,
                     QuitDate = DateTime.Parse("May 29 2017"),
                     QuitReason = "Got another job",
                     MailSent = "Yes",

                 });

            EmployeeQuits.Add(2,
                 new EmployeeQuit
                 {
                     EmployeeId = 2,
                     ProcessBegin = DateTime.Parse("Jan 22 2018"),
                     ProcessEnd = DateTime.Parse("Aug 02 2017"),
                     ApproverId = 2,
                     CHRAdvance = "20 DAYS",
                     TrainingCancel = "No",
                     HealthInsurance = "Beneficiary",
                     CHRNotes = "Good and hardworking, he outperformed our expectation",
                     CompanyIdCard = "taking back",
                     PC = "Left in a good shape",
                     Monitor = "Left in a good condition",
                     PhoneHeadSet = "taking back",
                     CioNotes = "No fault was found in him",
                     CreditCard = "submitted",
                     GSMCard = "Submitted",
                     CompanyVehicle = "None",
                     VehicleEntryStamp = "none",
                     BookKeepingAdvance = "None",
                     BANotes = "All due process observed",
                     Multinet = "Subcription cutoff",
                     Quit = true,
                     QuitDate = DateTime.Parse("May 29 2017"),
                     QuitReason = "Got another job",
                     MailSent = "Yes",

                 });

            EmployeeQuits.Add(3,
                 new EmployeeQuit
                 {
                     EmployeeId = 3,
                     ProcessBegin = DateTime.Parse("Jan 22 2018"),
                     ProcessEnd = DateTime.Parse("Nov 02 2017"),
                     ApproverId = 3,
                     CHRAdvance = "12 DAYS",
                     TrainingCancel = "No",
                     HealthInsurance = "Beneficiary",
                     CHRNotes = "Good and hardworking, he outperformed our expectation",
                     CompanyIdCard = "taking back",
                     PC = "Left in a good shape",
                     Monitor = "Left in a good condition",
                     PhoneHeadSet = "taking back",
                     CioNotes = "No fault was found in him",
                     CreditCard = "submitted",
                     GSMCard = "Submitted",
                     CompanyVehicle = "None",
                     VehicleEntryStamp = "none",
                     BookKeepingAdvance = "None",
                     BANotes = "All due process observed",
                     Multinet = "Subcription cutoff",
                     Quit = true,
                     QuitDate = DateTime.Parse("May 29 2017"),
                     QuitReason = "Got another job",
                     MailSent = "No",
                 });
            //);
            foreach (var employQu in EmployeeQuits.Values)
            {
                context.EmployeeQuits.Add(employQu);
            }
           // context.EmployeeQuits.AddRange(employqu);
             context.SaveChangesAsync();
        }

        public void SeedEmployTechSkills(AlloeContext context)
        {
            EmployeeTechnicalSkills.Add(1,
             // var employtec = new[] {
             // context.EmployeeTechnicalSkills.AddRange(
                new EmployeeTechnicalSkill
                {
                    EmployeeId = 1,
                    Name = "Microsoft azure Architect",
                    Level = Level.Advanced,

                    Notes = "Very qualified to take work in thr position",
                    SkillId = 1,
                    LevelId = 1,

                });

            EmployeeTechnicalSkills.Add(2,
                new EmployeeTechnicalSkill
                {
                    EmployeeId = 2,
                    Name = "Google Cloud Architect",
                    Level = Level.Beginner,

                    Notes = "Very qualified to take work in thr position",
                    SkillId = 2,
                    LevelId = 2,

                });

            EmployeeTechnicalSkills.Add(3,
                new EmployeeTechnicalSkill
                {
                    EmployeeId = 3,
                    Name = "Amazon Cloud Architect",
                    Level = Level.Intermediate,

                    Notes = "Very qualified to take work in thr position",
                    SkillId = 3,
                    LevelId = 3,
                });
           // );
            foreach(var employSki in EmployeeTechnicalSkills.Values)
            {
                context.EmployeeTechnicalSkills.Add(employSki);
            }
           // context.EmployeeTechnicalSkills.AddRange(employtec);
             context.SaveChangesAsync();
        }

        public void SeedEmployTrainings(AlloeContext context)
        {
            EmployeeTrainings.Add(1,
                // var employtrai = new[] {
                // context.EmployeeTrainings.AddRange(
                new EmployeeTraining
                {
                    EmployeeId = 1,
                    Name = ".Net Application Developer",
                    Location = "Lagos",
                    Duration = "6 month",
                    Provider = "Microsoft edx",

                    Start = DateTime.Parse("Mar 12 2015"),
                    Finish = DateTime.Parse("Nov 22 2016"),
                    Notes = "Very exceptional through the training"
                });

             EmployeeTrainings.Add(2,
               new EmployeeTraining
               {
                   EmployeeId = 2,
                   Name = " Application Developer",
                   Location = "Lagos",
                   Duration = "6 month",
                   Provider = "Microsoft edx",

                   Start = DateTime.Parse("Mar 12 2015"),
                   Finish = DateTime.Parse("Nov 22 2016"),
                   Notes = "Very exceptional through the training"
               });

             EmployeeTrainings.Add(3,
               new EmployeeTraining
               {
                   EmployeeId = 3,
                   Name = "java Application Developer",
                   Location = "abuja",
                   Duration = "6 month",
                   Provider = "Microsoft edx",

                   Start = DateTime.Parse("Mar 12 2015"),
                   Finish = DateTime.Parse("Nov 22 2016"),
                   Notes = "Very exceptional through the training"
               });
           //);
           

            foreach (var employtra in EmployeeTrainings.Values)
            {
                context.EmployeeTrainings.Add(employtra);
            }
           // context.EmployeeTrainings.AddRange(employtrai);
           context.SaveChangesAsync();
        }


        //public static byte[] StringToByteArray(string hex)
        //{
        //    return Enumerable.Range(0, hex.Length)
        //        .Where(x => x % 2 == 0)
        //       .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        //       .ToArray();
        //}
    }
}

//public void SaveImage(string base64String, string filepath)
//{
//    // image convert to base64string is base64String 
//    //File path is which path to save the image.
//    var bytess = Convert.FromBase64String(base64String);
//    using (var imageFile = new FileStream(filepath, FileMode.Create))
//    {
//        imageFile.Write(bytess, 0, bytess.Length);
//        imageFile.Flush();
//    }
//}


