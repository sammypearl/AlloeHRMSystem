//using AlloeHRMSystem.Domain.Entities;
//using AlloeHRMSystem.Domain.Enums;
//using AlloeHRMSystem.Domain.IdentityEntities;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Builder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlloeHRMSystem.Persistence
//{
//    public static class AlloeHRMSystemInitializerss
//    {

//        public static void Initialize(AlloeContext context,
//            UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
//        {
//            context.Database.EnsureCreated();

//            if (!context.AppUsers.Any())
//            {
//                SeedAppUsers(userManager); // Database has been seeded
//            }

//            if (!context.AppRoles.Any())
//            {
//                SeedAppRoles(roleManager); // Database has been seeded
//            }

//            if (!context.Employees.Any())
//            {
//                SeedEmployees(context); // Database has been seeded
//            }

//            if (!context.EmployeeAttachments.Any())
//            {
//                SeedEmployAttachment(context); // Database has been seeded
//            }

//            if (!context.EmployeeCertificates.Any())
//            {
//                SeedEmployAttachment(context); // Database has been seeded
//            }

//            if (!context.EmployeeEducations.Any())
//            {
//                SeedEmployEducations(context); // Database has been seeded
//            }

//            if (!context.EmployeeEmergencyCalls.Any())
//            {
//                SeedEmployEmergencyCall(context); // Database has been seeded
//            }

//            if (!context.EmployeeLanguages.Any())
//            {
//                SeedEmploLanguages(context); // Database has been seeded
//            }

//            if (!context.EmployeeProjects.Any())
//            {
//                SeedEmployProjects(context); // Database has been seeded
//            }

//            if (!context.EmployeeQuits.Any())
//            {
//                SeedEmployQuits(context); // Database has been seeded
//            }

//            if (!context.EmployeeTechnicalSkills.Any())
//            {
//                SeedEmployTechSkills(context); // Database has been seeded
//            }

//            if (!context.EmployeeTrainings.Any())
//            {
//                SeedEmployTrainings(context); // Database has been seeded
//            }

//        }

//        private static void SeedAppUsers(UserManager<AppUser> userManager)
//        {
//            var MyEmailAddress = "sammy1@samuel-ak.tech";
//            var MyPassword = "Sammyk@001";
//            if (userManager.FindByEmailAsync(MyEmailAddress) == null)
//            {
//                var appUsers = new AppUser
//                {
//                    EmployeeId = 1,
//                    UserName = MyEmailAddress,
//                    Email = MyEmailAddress,
//                    // Password = MyPassword,
//                    FirstName = "Samuel",
//                    LastName = "Gates",
//                    CreatedBy = "Sammy Lee",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    // CreatedBy = "Sammy Arthur",
//                    Title = "Mr",
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Google Inc",
//                    Department = Dept.Admin,
//                    JobTitle = "Software Engineer",
//                    FailedAttempCount = "",
//                    HomePhone = "+2348074766622",
//                    // Email = "sammy@myproject.com",
//                    Fax = "22344t44",
//                    MustChangePassword = true,
//                    CanDoCustomization = true,
//                    LastPasswordUpdate = DateTime.Parse("May 11 2013 11:30AM"),

//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    ExpirationWarningPeriod = DateTime.Parse("Nov 23 2016 10:30AM"),
//                    CanDoPassword = true,
//                    PasswordExpirationEnable = true,
//                    // CanDoPassword = true,
//                    CanMakeCall = true,

//                };
//                IdentityResult result = userManager.CreateAsync(appUsers, MyPassword).Result;
//                if (result.Succeeded)
//                {
//                    // await userManager.AddPasswordAsync(appUsers, MyPassword);
//                    userManager.AddToRoleAsync(appUsers, "Admin");
//                }
//            }

//            var MyEmailAddress2 = "sammy2@samuel-ak.tech";
//            var MyPassword2 = "Sammyk@002";
//            if (userManager.FindByEmailAsync(MyEmailAddress) == null)
//            {

//                var appUsers = new AppUser
//                {
//                    EmployeeId = 2,
//                    UserName = MyEmailAddress2,
//                    //  Password = MyPassword2,
//                    Email = MyEmailAddress2,
//                    FirstName = "Samuel",
//                    LastName = "Akinsoju",
//                    CreatedBy = "Steve Bannon",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    //  CreatedBy = "Sammy Arthur",
//                    Title = "Mr",
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Google Inc",
//                    Department = Dept.HR,
//                    JobTitle = "Network Engineer",
//                    FailedAttempCount = "",
//                    HomePhone = "+2348074766622",
//                    //  Email = "sammy@myproject.com",
//                    Fax = "22344t44",

//                    MustChangePassword = false,
//                    CanDoCustomization = true,
//                    LastPasswordUpdate = DateTime.Parse("May 11 2014 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    ExpirationWarningPeriod = DateTime.Parse("Mar 23 2016 10:30AM"),
//                    CanDoPassword = true,
//                    PasswordExpirationEnable = true,
//                    // CanDoPassword = true,
//                    CanMakeCall = true,

//                };

//                IdentityResult result = userManager.CreateAsync(appUsers, MyPassword2).Result;
//                if (result.Succeeded)
//                {
//                    // await userManager.AddPasswordAsync(appUsers, MyPassword);
//                    userManager.AddToRoleAsync(appUsers, "HR");
//                }

//            }

//            var MyEmailAddress3 = "sammy3@samuel-ak.tech";
//            var MyPassword3 = "Sammyk@003";
//            if (userManager.FindByEmailAsync(MyEmailAddress) == null)
//            {
//                var appUsers = new AppUser
//                {
//                    EmployeeId = 3,
//                    UserName = MyEmailAddress3,
//                    Email = MyEmailAddress3,
//                    // Password = "sammyk0001",
//                    FirstName = "Sammy Achillis",
//                    LastName = "Achillis",
//                    CreatedBy = "Sammy Arthur",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    // CreatedBy = "Sammy Arthur",
//                    Title = "Dr",
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Apple Inc",
//                    Department = Dept.IT,
//                    JobTitle = "IT Security Engineer",
//                    FailedAttempCount = "",
//                    HomePhone = "+2348074766622",
//                    // Email = "sammy@myproject.com",
//                    Fax = "22344t44",

//                    MustChangePassword = true,

//                    CanDoCustomization = true,
//                    LastPasswordUpdate = DateTime.Parse("May 11 2014 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    ExpirationWarningPeriod = DateTime.Parse("Jan 23 2016 10:30AM"),
//                    CanDoPassword = true,
//                    PasswordExpirationEnable = true,

//                    CanMakeCall = true,

//                };

//                IdentityResult result = userManager.CreateAsync(appUsers, MyPassword3).Result;
//                if (result.Succeeded)
//                {
//                    // await userManager.AddPasswordAsync(appUsers, MyPassword);
//                    userManager.AddToRoleAsync(appUsers, "Manager");
//                }
//            }

//            var MyEmailAddress4 = "sammy4@samuel-ak.tech";
//            var MyPassword4 = "Sammyk@004";
//            if (userManager.FindByEmailAsync(MyEmailAddress) == null)
//            {
//                var appUsers = new AppUser
//                {
//                    EmployeeId = 4,
//                    UserName = MyEmailAddress4,
//                    Email = MyEmailAddress4,
//                    // Password = "sammyk0001",
//                    FirstName = "Sammy Brendan",
//                    LastName = "Brendan",
//                    CreatedBy = "Lenon Arthur",
//                    CreateDate = DateTime.Parse("Jan 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    Title = "Dr",
//                    MobileNo = "+2348072623445",
//                    Language = "Spanish",
//                    Company = "Microsoft Corporation",
//                    Department = Dept.Maintenance,
//                    JobTitle = "IT Maintenance Engineer",
//                    FailedAttempCount = "",
//                    HomePhone = "+2348074766622",
//                    // Email = "sammy@myproject.com",
//                    Fax = "22664t44",

//                    MustChangePassword = true,

//                    CanDoCustomization = true,
//                    LastPasswordUpdate = DateTime.Parse("Dec 11 2014 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("Nov 23 2016 10:30AM"),
//                    ExpirationWarningPeriod = DateTime.Parse("Nov 23 2016 10:30AM"),
//                    CanDoPassword = true,
//                    PasswordExpirationEnable = true,

//                    CanMakeCall = true,

//                };

//                IdentityResult result = userManager.CreateAsync(appUsers, MyPassword4).Result;
//                if (result.Succeeded)
//                {
//                    // await userManager.AddPasswordAsync(appUsers, MyPassword);
//                    userManager.AddToRoleAsync(appUsers, "Employee");
//                }
//            }
//        }
//        private static void SeedAppRoles(RoleManager<AppRole> roleManager)
//        {
//            if (!roleManager.RoleExistsAsync("Admin").Result)
//            {
//                AppRole role = new AppRole();
//                role.Name = "Admin";
//                role.Description = "Responsible for creating new AppUsers";
//                role.CreatedBy = "Samuel";
//                role.CreateDate = DateTime.Parse("May 11 2014 11:30AM");
//                role.ModifiedBy = "Samuel";
//                role.ModifiedDate = DateTime.Parse("May 11 2014 11:30AM");
//                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
//            }

//            if (!roleManager.RoleExistsAsync("HR").Result)
//            {
//                AppRole role = new AppRole();
//                role.Name = "HR";
//                role.Description = "Responsible for creating new Employee";
//                role.CreatedBy = "Gary";
//                role.CreateDate = DateTime.Parse("Feb 24 2015 11:30AM");
//                role.ModifiedBy = "Gary";
//                role.ModifiedDate = DateTime.Parse("May 17 2017 11:30AM");
//                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
//            }

//            if (!roleManager.RoleExistsAsync("Manager").Result)
//            {
//                AppRole role = new AppRole();
//                role.Name = "Manager";
//                role.Description = "Responsible for Assigning Roles Managing All AppUsers in its Dept";
//                role.CreatedBy = "Trump";
//                role.CreateDate = DateTime.Parse("May 21 2012 10:30AM");
//                role.ModifiedBy = "Trump";
//                role.ModifiedDate = DateTime.Parse("Feb 20 2013 11:30AM");
//                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
//            }

//            if (!roleManager.RoleExistsAsync("Employee").Result)
//            {
//                AppRole role = new AppRole();
//                role.Name = "Employee";
//                role.Description = "Normal Role for Every AppUsers";
//                role.CreatedBy = "Bill";
//                role.CreateDate = DateTime.Parse("Oct 23 2014 11:30AM");
//                role.ModifiedBy = "Bill";
//                role.ModifiedDate = DateTime.Parse("May 12 2015 11:30AM");
//                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
//            }
//        }
//        private static void SeedEmployees(AlloeContext context)
//        {
//            var employees = new Employee[] {
//             // context.Employees.AddRange(

//                    new Employee
//                    {
//                        EmployeeId = 1,
//                        Name = "Samuel Akinsoju",
//                        Surname = "Akinsoju",
//                        // HomeAddress = "5, Sesame street NYC",
//                        CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                        ModifiedBy = "Lennon Lewwis",
//                        CreatedBy = "Steven Arthur",
//                        LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                        // FileSize = 20,
//                        Phone = "+2348062623445",
//                        CellPhone = "+2349080060023",
//                        Email = "sammy@myproject.com",
//                        HomeAddress = "5, Sesame street NYC",
//                        Department = Dept.HR,
//                        City = "Lagos",
//                        Country = "Nigeria",
//                        QuitDate = DateTime.Parse("Mar 23 2011 12:00AM"),
//                        StartDate = DateTime.Parse("Mar 23 2011 12:00AM"),
//                        GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                        // Department = Dept.HR,
//                        JobTitle = "IT Support Engineer",
//                        Supervisor = "Robbin William",
//                        Rank = "IT Head",
//                        BloodType = "B+",
//                        MaritalStatus = "Single",
//                        DriverLicence = "Avalable",
//                        Confirmation = "Yes",
//                        DateOfBirth = DateTime.Parse("Jan 26 1987 12:00AM"),
//                        Gender = "Male",
//                        //  Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                        PhotoPath = "",
//                        Nationality = "Nigerian",
//                        HousePhone = "+2349088844433",
//                        IsLeavedJob = false,
//                        LeaveJobDate = DateTime.Parse("Jan 22 2019 11:00AM"),
//                        LeaveJobReason = "Not getting enough vacation",
//                        TaxNo = "23334eeea345",
//                        ContractType = "ShortTerm",
//                        JobLocation = "Lagos",
//                        OfficeSeat = "23",
//                        LegalDayOff = "9"


//                    },


//                    new Employee
//                    {
//                        EmployeeId = 2,
//                        Name = "Samuel Stacey",
//                        Surname = "Stacey",
//                        //  HomeAddress = "6, Sesame street NYC",
//                        CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                        ModifiedBy = "Lennon Lewwis",
//                        CreatedBy = "Sammy Arthur",
//                        LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                        //FileSize = 20,
//                        Phone = "+2348062623445",
//                        CellPhone = "+2349080060023",
//                        Email = "sammyk@myproject.com",
//                        HomeAddress = "6, Sesame street NYC",
//                        Department = Dept.IT,
//                        City = "Prague",
//                        Country = "Slovekia",
//                        QuitDate = DateTime.Parse("Mar 23 2019 12:00AM"),
//                        StartDate = DateTime.Parse("Mar 23 2012 12:00AM"),
//                        GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                        // Department = Dept.IT,
//                        JobTitle = "Software Engineer",
//                        Supervisor = "Satyr Nadella",
//                        Rank = "Senior Software Engineer",
//                        BloodType = "B+",
//                        MaritalStatus = "Married",
//                        DriverLicence = "Avalable",
//                        Confirmation = "Yes",
//                        DateOfBirth = DateTime.Parse("Jan 26 1984 12:00AM"),
//                        Gender = "Male",
//                        //   Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                        PhotoPath = "",
//                        Nationality = "British",
//                        HousePhone = "+2349088844433",
//                        IsLeavedJob = false,
//                        LeaveJobDate = DateTime.Parse("Aug 22 2019 11:00AM"),
//                        LeaveJobReason = "Not getting enough vacation",
//                        TaxNo = "23334eeea345",
//                        ContractType = "ShortTerm",
//                        JobLocation = "USA",
//                        OfficeSeat = "10",
//                        LegalDayOff = "32"


//                    },


//                    new Employee
//                    {
//                        EmployeeId = 3,
//                        Name = "Samuel Arthur",
//                        Surname = "Arthur",
//                        //  HomeAddress = "7, Sesame street NYC",
//                        CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                        ModifiedBy = "Lennon Lewwis",
//                        CreatedBy = "Sammy Arthur",
//                        LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                        // FileSize = 20,
//                        Phone = "+2348062623445",
//                        CellPhone = "+2349080060023",
//                        Email = "sammey@myproject.com",
//                        HomeAddress = "7, Sesame street NYC",
//                        City = "Budapest",
//                        Country = "Romania",
//                        QuitDate = DateTime.Parse("Sep 23 2014 12:00AM"),
//                        StartDate = DateTime.Parse("Mar 23 2012 12:00AM"),
//                        GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                        Department = Dept.Admin,
//                        JobTitle = "Software Developer",
//                        Supervisor = "Robbin William",
//                        Rank = "Project Lead",
//                        BloodType = "B+",
//                        MaritalStatus = "Single",
//                        DriverLicence = "Avalable",
//                        Confirmation = "Yes",
//                        DateOfBirth = DateTime.Parse("Jan 26 1987 12:00AM"),
//                        Gender = "Femaale",
//                        //  Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                        PhotoPath = "",
//                        Nationality = "British",
//                        HousePhone = "+2349088844433",
//                        IsLeavedJob = false,
//                        LeaveJobDate = DateTime.Parse("Nov 22 2019 11:00AM"),
//                        LeaveJobReason = "Not getting enough vacation",
//                        TaxNo = "23334eeea345",
//                        ContractType = "ShortTerm",
//                        JobLocation = "Britain",
//                        OfficeSeat = "20",
//                        LegalDayOff = "22"
//                    }

//            };
//            // );
//            context.Employees.AddRange(employees);
//            context.SaveChanges();
//        }

//        private static void SeedEmployAttachment(AlloeContext context)
//        {
//            context.EmployeeAttachments.AddRange
//            (
//               new EmployeeAttachment
//               {
//                   FileName = "Degree Certificate",
//                   EmployeeId = 1,
//                   FileId = 2,
//                   URLOnly = "www.google.com",
//                   Notes = "My bachelor degree certificate",
//                   FileSize = 20,
//                   Confirmation = "Yes",
//                   Type = FileType.Excel,
//               },


//               new EmployeeAttachment
//               {
//                   FileName = "High School Certificate",
//                   EmployeeId = 2,
//                   FileId = 3,
//                   URLOnly = "www.google.com",
//                   Notes = "My bachelor degree certificate",
//                   FileSize = 20,
//                   Confirmation = "Yes",
//                   Type = FileType.Picture,


//               },


//               new EmployeeAttachment
//               {
//                   FileName = "Resume Document",
//                   EmployeeId = 3,
//                   FileId = 4,
//                   URLOnly = "www.google.com",
//                   Notes = "My bachelor degree certificate",
//                   FileSize = 20,
//                   Confirmation = "Yes",
//                   Type = FileType.Pdf,

//               }
//            );
//            context.SaveChanges();

//        }




//        private static void SeedEmployCertificates(AlloeContext context)
//        {

//            context.EmployeeCertificates.AddRange(

//                new EmployeeCertificate
//                {
//                    EmployeeId = 1,
//                    Name = "Certified Ethical Hacker",
//                    Provider = "EC Counsil",
//                    // EmployeeId = 1,
//                    Confirmation = "Yes",
//                    Date = DateTime.Parse("Aug 15 2019 9:00AM"),
//                    Notes = "Certificat issued for passing CEH Exam",

//                },


//               new EmployeeCertificate
//               {
//                   EmployeeId = 2,
//                   Name = "Certified Ethical Hacker",
//                   Provider = "EC Counsil",
//                   //  EmployeeId = 2,
//                   Confirmation = "Yes",
//                   Date = DateTime.Parse("Aug 15 2019 9:00AM"),
//                   Notes = "Certificat issued for passing CEH Exam",

//               },


//               new EmployeeCertificate
//               {
//                   EmployeeId = 3,
//                   Name = "Certified Ethical Hacker",
//                   Provider = "EC Counsil",
//                   // EmployeeId = 3,
//                   Confirmation = "Yes",
//                   Date = DateTime.Parse("Aug 15 2019 9:00AM"),
//                   Notes = "Certificat issued for passing CEH Exam",

//               }

//            );

//            context.SaveChanges();
//        }



//        private static void SeedEmployEducations(AlloeContext context)
//        {
//            context.EmployeeEducations.AddRange(

//                new EmployeeEducation
//                {
//                    EmployeeId = 1,
//                    Department = "Computer Engineering",
//                    DegreeId = 1,
//                    Degree = "MBA in Information Technology",
//                    Institution = "Preston University USA",
//                    StillStudying = "No",
//                    Confirmation = "Yes",
//                    Notes = "Finish my MBA in PRESTON University USA ",
//                    Thesis = "Driving a startup to middle scale enterprise in the USA",
//                    EntranceDate = DateTime.Parse("Feb 22 2012 13:00AM"),
//                    GraduationDate = DateTime.Parse("Jan 20 2017 11:00AM"),



//                },


//                new EmployeeEducation
//                {
//                    EmployeeId = 2,
//                    Department = "Business Administration",
//                    DegreeId = 2,
//                    Degree = "MBA in Information Technology",
//                    Institution = "Preston University USA",
//                    StillStudying = "No",
//                    Confirmation = "Yes",
//                    Notes = "Finish my MBA in PRESTON University USA ",
//                    Thesis = "Driving a startup to middle scale enterprise in the USA",
//                    EntranceDate = DateTime.Parse("Feb 22 2013 12:00AM"),
//                    GraduationDate = DateTime.Parse("Jan 26 2017 12:00AM"),



//                },


//               new EmployeeEducation
//               {
//                   EmployeeId = 3,
//                   Department = "Accounting",
//                   DegreeId = 3,
//                   Degree = "MBA in Information Technology",
//                   Institution = "Preston University USA",
//                   StillStudying = "No",
//                   Confirmation = "Yes",
//                   Notes = "Finish my MBA in PRESTON University USA ",
//                   Thesis = "Driving a startup to middle scale enterprise in the USA",
//                   EntranceDate = DateTime.Parse("Feb 22 2014 12:00AM"),
//                   GraduationDate = DateTime.Parse("Jan 28 2017 12:00AM"),

//               }

//            );

//        }

//        private static void SeedEmployEmergencyCall(AlloeContext context)
//        {
//            context.EmployeeEmergencyCalls.AddRange(
//                 new EmployeeEmergencyCall
//                 {
//                     EmployeeId = 1,
//                     Name = "Smuel Akinsosju",
//                     SurName = "Akinsoju",
//                     RelationTo = "MaCalley",
//                     Phone = "+2348060050022"


//                 },


//                new EmployeeEmergencyCall
//                {
//                    EmployeeId = 2,
//                    Name = "Smuel Akinju",
//                    SurName = "Akinju",
//                    RelationTo = "MaCalley",
//                    Phone = "+2348060050022"


//                },


//                new EmployeeEmergencyCall
//                {
//                    EmployeeId = 3,
//                    Name = "Smuel Akinsosju",
//                    SurName = "Akins",
//                    RelationTo = "MaCalley",
//                    Phone = "+2348060050022"
//                }
//             );
//            context.SaveChanges();
//        }

//        private static void SeedEmploLanguages(AlloeContext context)
//        {
//            context.EmployeeLanguages.AddRange(
//                new EmployeeLanguage
//                {
//                    EmployeeId = 1,
//                    Language = "Spanish",
//                    WrittenLevel = Level.Beginner,
//                    SpeakingLevel = Level.Intermediate,
//                    NativeLang = "No",
//                    LanguageId = 1,
//                    Notes = "Can speak spanish on a professional level",
//                    Confirmation = "Yes"

//                },


//               new EmployeeLanguage
//               {
//                   EmployeeId = 2,
//                   Language = "French",
//                   WrittenLevel = Level.Advanced,
//                   SpeakingLevel = Level.Intermediate,
//                   NativeLang = "No",
//                   LanguageId = 2,
//                   Notes = "Can speak spanish on a professional level",
//                   Confirmation = "Yes"

//               },


//               new EmployeeLanguage
//               {
//                   EmployeeId = 3,
//                   Language = "Spanish",
//                   WrittenLevel = Level.Beginner,
//                   SpeakingLevel = Level.Intermediate,
//                   NativeLang = "Yes",
//                   LanguageId = 3,
//                   Notes = "Can speak spanish on a professional level",
//                   Confirmation = "Yes"
//               }
//           );
//            context.SaveChanges();
//        }

//        private static void SeedEmployProjects(AlloeContext context)
//        {
//            context.EmployeeProjects.AddRange(
//                new EmployeeProject
//                {
//                    EmployeeId = 1,
//                    Name = "Developing a complaints logging system",
//                    Start = DateTime.Parse("Jan 12 2015 17:00PM"),
//                    Finish = DateTime.Parse("Sept 20 2015 18:00PM"),
//                    Completed = "Yes",
//                    JobPosition = "Software Support",
//                    ProjectId = 1,
//                    Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                    Confirmation = "Yes",

//                },


//               new EmployeeProject
//               {
//                   EmployeeId = 2,
//                   Name = "Developing a complaints logging system",
//                   Start = DateTime.Parse("Jan 12 2015 17:00PM"),
//                   Finish = DateTime.Parse("Sep 22 2015 18:00PM"),
//                   Completed = "Yes",
//                   JobPosition = "Software Developer",
//                   ProjectId = 1,
//                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                   Confirmation = "Yes",

//               },


//               new EmployeeProject
//               {
//                   EmployeeId = 3,
//                   Name = "Developing a complaints logging system",
//                   Start = DateTime.Parse("Jan 12 2015 17:00PM"),
//                   Finish = DateTime.Parse("Sept 20 2015 18:00PM"),
//                   Completed = "No",
//                   JobPosition = "Software Engineer",
//                   ProjectId = 1,
//                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                   Confirmation = "No",
//               }
//           );
//            context.SaveChanges();
//        }

//        private static void SeedEmployQuits(AlloeContext context)
//        {
//            context.EmployeeQuits.AddRange(
//                 new EmployeeQuit
//                 {
//                     EmployeeId = 1,
//                     ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                     ProcessEnd = DateTime.Parse("Dec 02 2017 23:00PM"),
//                     ApproverId = 1,
//                     CHRAdvance = "30 DAYS",
//                     TrainingCancel = "Yes",
//                     HealthInsurance = "Beneficiary",
//                     CHRNotes = "Good and hardworking, he outperformed our expectation",
//                     CompanyIdCard = "taking back",
//                     PC = "Left in a good shape",
//                     Monitor = "Left in a good condition",
//                     PhoneHeadSet = "taking back",
//                     CioNotes = "No fault was found in him",
//                     CreditCard = "submitted",
//                     GSMCard = "Submitted",
//                     CompanyVehicle = "None",
//                     VehicleEntryStamp = "none",
//                     BookKeepingAdvance = "None",
//                     BANotes = "All due process observed",
//                     Multinet = "Subcription cutoff",
//                     Quit = true,
//                     QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                     QuitReason = "Got another job",
//                     MailSent = "Yes",

//                 },


//                 new EmployeeQuit
//                 {
//                     EmployeeId = 2,
//                     ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                     ProcessEnd = DateTime.Parse("Aug 02 2017 23:00PM"),
//                     ApproverId = 2,
//                     CHRAdvance = "20 DAYS",
//                     TrainingCancel = "No",
//                     HealthInsurance = "Beneficiary",
//                     CHRNotes = "Good and hardworking, he outperformed our expectation",
//                     CompanyIdCard = "taking back",
//                     PC = "Left in a good shape",
//                     Monitor = "Left in a good condition",
//                     PhoneHeadSet = "taking back",
//                     CioNotes = "No fault was found in him",
//                     CreditCard = "submitted",
//                     GSMCard = "Submitted",
//                     CompanyVehicle = "None",
//                     VehicleEntryStamp = "none",
//                     BookKeepingAdvance = "None",
//                     BANotes = "All due process observed",
//                     Multinet = "Subcription cutoff",
//                     Quit = true,
//                     QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                     QuitReason = "Got another job",
//                     MailSent = "Yes",

//                 },


//                 new EmployeeQuit
//                 {
//                     EmployeeId = 3,
//                     ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                     ProcessEnd = DateTime.Parse("Nov 02 2017 23:00PM"),
//                     ApproverId = 3,
//                     CHRAdvance = "12 DAYS",
//                     TrainingCancel = "No",
//                     HealthInsurance = "Beneficiary",
//                     CHRNotes = "Good and hardworking, he outperformed our expectation",
//                     CompanyIdCard = "taking back",
//                     PC = "Left in a good shape",
//                     Monitor = "Left in a good condition",
//                     PhoneHeadSet = "taking back",
//                     CioNotes = "No fault was found in him",
//                     CreditCard = "submitted",
//                     GSMCard = "Submitted",
//                     CompanyVehicle = "None",
//                     VehicleEntryStamp = "none",
//                     BookKeepingAdvance = "None",
//                     BANotes = "All due process observed",
//                     Multinet = "Subcription cutoff",
//                     Quit = true,
//                     QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                     QuitReason = "Got another job",
//                     MailSent = "No",
//                 }
//            );
//            context.SaveChanges();
//        }

//        private static void SeedEmployTechSkills(AlloeContext context)
//        {
//            context.EmployeeTechnicalSkills.AddRange(
//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 1,
//                    Name = "Microsoft azure Architect",
//                    Level = Level.Advanced,
//                    Confirmation = "Yes",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 1,
//                    LevelId = 1,

//                },


//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 2,
//                    Name = "Google Cloud Architect",
//                    Level = Level.Beginner,
//                    Confirmation = "No",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 2,
//                    LevelId = 2,

//                },


//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 3,
//                    Name = "Amazon Cloud Architect",
//                    Level = Level.Intermediate,
//                    Confirmation = "Yes",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 3,
//                    LevelId = 3,
//                }
//            );
//            context.SaveChanges();
//        }

//        private static void SeedEmployTrainings(AlloeContext context)
//        {

//            context.EmployeeTrainings.AddRange(
//                new EmployeeTraining
//                {
//                    EmployeeId = 1,
//                    Name = ".Net Application Developer",
//                    Location = "Lagos",
//                    Duration = "6 month",
//                    Provider = "Microsoft edx",
//                    Confirmation = "Yes",
//                    Start = DateTime.Parse("Mar 12 2015 12:00AM"),
//                    Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                    Notes = "Very exceptional through the training"
//                },


//               new EmployeeTraining
//               {
//                   EmployeeId = 2,
//                   Name = " Application Developer",
//                   Location = "Lagos",
//                   Duration = "6 month",
//                   Provider = "Microsoft edx",
//                   Confirmation = "Yes",
//                   Start = DateTime.Parse("Mar 12 2015 12:00AM"),
//                   Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                   Notes = "Very exceptional through the training"
//               },


//               new EmployeeTraining
//               {
//                   EmployeeId = 3,
//                   Name = "java Application Developer",
//                   Location = "abuja",
//                   Duration = "6 month",
//                   Provider = "Microsoft edx",
//                   Confirmation = "Yes",
//                   Start = DateTime.Parse("Mar 12 2015 12:00AM"),
//                   Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                   Notes = "Very exceptional through the training"
//               }
//           );
//            context.SaveChanges();
//        }


//        public static byte[] StringToByteArray(string hex)
//        {
//            return Enumerable.Range(0, hex.Length)
//                .Where(x => x % 2 == 0)
//               .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
//               .ToArray();
//        }
//    }
//}

////public void SaveImage(string base64String, string filepath)
////{
////    // image convert to base64string is base64String 
////    //File path is which path to save the image.
////    var bytess = Convert.FromBase64String(base64String);
////    using (var imageFile = new FileStream(filepath, FileMode.Create))
////    {
////        imageFile.Write(bytess, 0, bytess.Length);
////        imageFile.Flush();
////    }
////}



