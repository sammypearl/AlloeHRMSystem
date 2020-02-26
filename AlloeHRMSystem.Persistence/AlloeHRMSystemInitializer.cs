//using AlloeHRMSystem.Domain.Entities;
//using AlloeHRMSystem.Domain.Enums;
//using AlloeHRMSystem.Domain.IdentityEntities;
//using Microsoft.AspNetCore.Builder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace AlloeHRMSystem.Persistence
//{
//    public class AlloeHRMSystemInitializer
//    {
//        //private readonly Dictionary<int, AppUser> AppUsers = new Dictionary<int, AppUser>();
//        // private readonly Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
//        //private readonly Dictionary<int, EmployeeAttachment> EmployeeAttachments = new Dictionary<int, EmployeeAttachment>();
//        //private readonly Dictionary<int, EmployeeCertificate> EmployeeCertificates = new Dictionary<int, EmployeeCertificate>();
//        //private readonly Dictionary<int, EmployeeEducation> EmployeeEducations = new Dictionary<int, EmployeeEducation>();
//        //private readonly Dictionary<int, EmployeeEmergencyCall> EmployeeEmergencyCalls = new Dictionary<int, EmployeeEmergencyCall>();

//        //private readonly Dictionary<int, EmployeeLanguage> EmployeeLanguages = new Dictionary<int, EmployeeLanguage>();
//        //private readonly Dictionary<int, EmployeeProject> EmployeeProjects = new Dictionary<int, EmployeeProject>();
//        //private readonly Dictionary<int, EmployeeQuit> EmployeeQuits = new Dictionary<int, EmployeeQuit>();
//        //private readonly Dictionary<int, EmployeeTechnicalSkill> EmployeeTechnicalSkills = new Dictionary<int, EmployeeTechnicalSkill>();
//        //private readonly Dictionary<int, EmployeeTraining> EmployeeTrainings = new Dictionary<int, EmployeeTraining>();


//        public static void Initialize(AlloeContext context)
//        {
//            context.Database.EnsureCreated();

//            if (context.Employees.Any())
//            {
//                return; // Database has been seeded
//            }
//            //var initializer = new AlloeHRMSystemInitializer();
//            //initializer.SeedEverything(context);
//        }

//        //public void SeedEverything(AlloeContext context)
//        //{
//        //    context.Database.EnsureCreated();

//        //    if (context.Employees.Any())
//        //    {
//        //        return; // Database has been seeded
//        //    }

//        //    //SeedAppUsers(context);
//        //    //SeedEmployees(context);
          

//        //    //SeedEmployeeAttachments(context);

//        //    //SeedEmployeeCertificates(context);

          
//        //    //SeedEmployeeEducations(context);
//        //    //SeedEmployeeEmergencyCalls(context);

//        //    //SeedEmployeeLanguages(context);

//        //    //SeedEmployeeProjects(context);

//        //    //SeedEmployeeQuits(context);

//        //    //SeedEmployeeTechnicalSkills(context);

//        //    //SeedEmployeeTrainings(context);
//        //}


//       public void SeedAppUsers(AlloeContext context)
//        {
            
//                new AppUser
//                {
                    
//                    UserName = "SAMMYK09",
//                    Password = "sammyk0001",
//                    Name = "Samuel Arthur",
//                    Surname = "Arthur",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    CreatedBy = "Sammy Arthur",
//                    Title = "Mr",
           
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Google Inc",
                 
//                    JobTitle = "Software Engineer",
//                    FailedAttempCount = "",
                
//                    PhoneNo = "+2348074766622",
//                    Email = "sammy@myproject.com",
//                    Fax = "22344t44",
//                    MustChangePassword = true,
//                    CanDoCustomization = "Yes",
//                    LastPasswordUpdate = DateTime.Parse("May 11 2013 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    PasswordExpirationEnable = true,
//                    CanDoPassword = true,
                   
               
//                    CanMakeCall = true,

//                });

//           // AppUsers.Add(2,
//                new AppUser
//                {
                    
//                    UserName = "SAMMYK033",
//                    Password = "sammyk01",
//                    Name = "Samuel Akinsoju",
//                    Surname = "Akinsoju",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    CreatedBy = "Sammy Arthur",
//                    Title = "Mr",
                    
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Google Inc",
//                    CustomerDepartment = "IT",
//                    JobTitle = "Network Engineer",
//                    FailedAttempCount = "",
//                    PhoneNo = "+2348074766622",
//                    Email = "sammy@myproject.com",
//                    Fax = "22344t44",

//                    MustChangePassword = false,

//                    CanDoCustomization = "No",
//                    LastPasswordUpdate = DateTime.Parse("May 11 2014 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    PasswordExpirationEnable = true,
//                    CanDoPassword = true,
                   
                  
//                    CanMakeCall = true,

//                });

//            AppUsers.Add(3,
//                new AppUser
//                {
                    
//                    UserName = "SAMMYK009",
//                    Password = "sammyk0001",
//                    Name = "Sammy Achillis",
//                    Surname = "Achillis",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifyBy = "Lennon Lewwis",
//                    CreatedBy = "Sammy Arthur",
//                    Title = "Dr",
//                    MobileNo = "+2348062623445",
//                    Language = "English",
//                    Company = "Apple Inc",
//                    CustomerDepartment = "HR",
//                    JobTitle = "IT Security Engineer",
//                    FailedAttempCount = "",
//                    PhoneNo = "+2348074766622",
//                    Email = "sammy@myproject.com",
//                    Fax = "22344t44",

//                    MustChangePassword = true,

//                    CanDoCustomization = "No",
//                    LastPasswordUpdate = DateTime.Parse("May 11 2014 11:30AM"),
//                    ExpirationPeriod = DateTime.Parse("May 23 2016 10:30AM"),
//                    PasswordExpirationEnable = true,
//                    CanDoPassword = false,
//                    CanMakeCall = true,

//                });
//            foreach (var appUser in AppUsers.Values)
//            {
//                context.AppUsers.Add(appUser);
//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployees(AlloeContext context)
//        {
//            Employees.Add(1,
//                new Employee
//                {
//                    EmployeeId = 1,
//                    Name = "Samuel Akinsoju",
//                    Surname = "Akinsoju",
//                    HomeAddress = "5, Sesame street NYC",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifiedBy = "Lennon Lewwis",
//                    CreatedBy = "Steven Arthur",
//                    LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                    FileSize = 20,
//                    Phone = "+2348062623445",
//                    CellPhone = "+2349080060023",
//                    Email = "sammy@myproject.com",
//                    City = "Lagos",
//                    Country = "Nigeria",
//                    StartDate = DateTime.Parse("Mar 23 2011 12:00AM"),
//                    GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                    Department = Dept.HR,
//                    JobTitle = "IT Support Engineer",
//                    Supervisor = "Robbin William",
//                    Rank = "IT Head",
//                    BloodType = "B+",
//                    MaritalStatus = "Single",
//                    DriverLicence = "Avalable",
//                    Confirmation = "Yes",
//                    DateOfBirth = DateTime.Parse("Jan 26 1987 12:00AM"),
//                    Gender = "Male",
//                    Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                    PhotoPath = "",
//                    Nationality = "Nigerian",
//                    HousePhone = "+2349088844433",
//                    IsLeavedJob = false,
//                    LeaveJobDate = DateTime.Parse("April 22 2019 11:00AM"),
//                    LeaveJobReason = "Not getting enough vacation",
//                    TaxNo = "23334eeea345",
//                    ContractType = "ShortTerm",
//                    JobLocation = "Lagos",
//                    OfficeSeat = "23",
//                    LegalDayOff = "9"


//                });

//            Employees.Add(2,
//                new Employee
//                {
//                    EmployeeId = 2,
//                    Name = "Samuel Stacey",
//                    Surname = "Stacey",
//                    HomeAddress = "6, Sesame street NYC",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifiedBy = "Lennon Lewwis",
//                    CreatedBy = "Sammy Arthur",
//                    LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                    FileSize = 20,
//                    Phone = "+2348062623445",
//                    CellPhone = "+2349080060023",
//                    Email = "sammyk@myproject.com",
//                    City = "Prague",
//                    Country = "Slovekia",
//                    StartDate = DateTime.Parse("Mar 23 2012 12:00AM"),
//                    GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                    Department = Dept.IT,
//                    JobTitle = "Software Engineer",
//                    Supervisor = "Satyr Nadella",
//                    Rank = "Senior Software Engineer",

//                    BloodType = "B+",
//                    MaritalStatus = "Married",
//                    DriverLicence = "Avalable",
//                    Confirmation = "Yes",
//                    DateOfBirth = DateTime.Parse("Jan 26 1984 12:00AM"),
//                    Gender = "Male",
//                    Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                    PhotoPath = "",
//                    Nationality = "British",
//                    HousePhone = "+2349088844433",
//                    IsLeavedJob = false,
//                    LeaveJobDate = DateTime.Parse("April 22 2019 11:00AM"),
//                    LeaveJobReason = "Not getting enough vacation",
//                    TaxNo = "23334eeea345",
//                    ContractType = "ShortTerm",
//                    JobLocation = "USA",
//                    OfficeSeat = "10",
//                    LegalDayOff = "32"


//                });

//            Employees.Add(3,
//                new Employee
//                {
//                    EmployeeId = 3,
//                    Name = "Samuel Arthur",
//                    Surname = "Arthur",
//                    HomeAddress = "7, Sesame street NYC",
//                    CreateDate = DateTime.Parse("Feb 20 2018 12:00AM"),
//                    ModifiedBy = "Lennon Lewwis",
//                    CreatedBy = "Sammy Art hur",
//                    LastModified = DateTime.Parse("Feb 28 2018 12:00AM"),
//                    FileSize = 20,
//                    Phone = "+2348062623445",
//                    CellPhone = "+2349080060023",
//                    Email = "sammey@myproject.com",
//                    City = "Budapest",
//                    Country = "Romania",
//                    StartDate = DateTime.Parse("Mar 23 2014 12:00AM"),
//                    GraduationDate = DateTime.Parse("May 11 2016 12:00AM"),
//                    Department = Dept.Admin,
//                    JobTitle = "Software Developer",
//                    Supervisor = "Robbin William",
//                    Rank = "Project Lead",
//                    BloodType = "B+",
//                    MaritalStatus = "Single",
//                    DriverLicence = "Avalable",
//                    Confirmation = "Yes",
//                    DateOfBirth = DateTime.Parse("Jan 26 1987 12:00AM"),
//                    Gender = "Femaale",
//                    Photo = StringToByteArray("232332EEEEEEED333422242411111111111111111111111000000000000000000000000EEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEEEEEEEEEEEEEE333333333333333333333334444444444444444444444444444444444442222222222222222222222222222222222EEE2221EEEE"),
//                    PhotoPath = "",
//                    Nationality = "British",
//                    HousePhone = "+2349088844433",
//                    IsLeavedJob = false,
//                    LeaveJobDate = DateTime.Parse("April 22 2019 11:00AM"),
//                    LeaveJobReason = "Not getting enough vacation",
//                    TaxNo = "23334eeea345",
//                    ContractType = "ShortTerm",
//                    JobLocation = "Britain",
//                    OfficeSeat = "20",
//                    LegalDayOff = "22"


//                });
//            foreach (var employee in Employees.Values)
//            {
//                context.Employees.Add(employee);
//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployeeAttachments(AlloeContext context)
//        {
//            EmployeeAttachments.Add(1,
//                new EmployeeAttachment
//                {
//                    FileName = "Degree Certificate",
//                    EmployeeId = 1,
//                    FileId = 2,
//                    URLOnly = "www.google.com",
//                    Notes = "My bachelor degree certificate",
//                    FileSize = 20,
//                    Confirmation = "Yes",
//                    Type = FileType.Excel,
//                });

//            EmployeeAttachments.Add(2,
//                new EmployeeAttachment
//                {
//                    FileName = "Degree Certificate",
//                    EmployeeId = 2,
//                    FileId = 3,
//                    URLOnly = "www.google.com",
//                    Notes = "My bachelor degree certificate",
//                    FileSize = 20,
//                    Confirmation = "Yes",
//                    Type = FileType.Picture,
                    

//                });

//            EmployeeAttachments.Add(3,
//                new EmployeeAttachment
//                {
//                    FileName = "Degree Certificate",
//                    EmployeeId = 3,
//                    FileId = 4,
//                    URLOnly = "www.google.com",
//                    Notes = "My bachelor degree certificate",
//                    FileSize = 20,
//                    Confirmation = "Yes",
//                    Type = FileType.Pdf,
                    

//                });

//            foreach (var employeeattach in EmployeeAttachments.Values)
//            {
//                context.EmployeeAttachments.Add(employeeattach);
                
//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployeeCertificates(AlloeContext context)
//        {
//            EmployeeCertificates.Add(1,
//                new EmployeeCertificate
//                {
//                    Name = "Certified Ethical Hacker",
//                    Provider = "EC Counsil",
//                    EmployeeId = 1,
//                    Confirmation = "Yes",
//                    Date = DateTime.Parse("August 15 2019 9:00AM"),
//                    Notes = "Certificat issued for passing CEH Exam",

//                });

//            EmployeeCertificates.Add(2,
//               new EmployeeCertificate
//               {
//                   Name = "Certified Ethical Hacker",
//                   Provider = "EC Counsil",
//                   EmployeeId = 2,
//                   Confirmation = "Yes",
//                   Date = DateTime.Parse("August 15 2019 9:00AM"),
//                   Notes = "Certificat issued for passing CEH Exam",

//               });

//            EmployeeCertificates.Add(3,
//               new EmployeeCertificate
//               {
//                   Name = "Certified Ethical Hacker",
//                   Provider = "EC Counsil",
//                   EmployeeId = 3,
//                   Confirmation = "Yes",
//                   Date = DateTime.Parse("August 15 2019 9:00AM"),
//                   Notes = "Certificat issued for passing CEH Exam",

//               });
//            foreach (var employeecert in EmployeeCertificates.Values)
//            {
//                context.EmployeeCertificates.Add(employeecert);
//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployeeEducations(AlloeContext context)
//        {
//            EmployeeEducations.Add(1,
//                new EmployeeEducation
//                {
//                    EmployeeId = 1,
//                    Department = "HR",
//                    DegreeId = 1,
//                    Degree = "MBA in Information Technology",
//                    Institution = "Preston University USA",
//                    StillStudying = "No",
//                    Confirmation = "Yes",
//                    Notes = "Finish my MBA in PRESTON University USA ",
//                    Thesis = "Driving a startup to middle scale enterprise in the USA",
//                    EntranceDate = DateTime.Parse("Feb 22 2012 13:00AM"),
//                    GraduationDate = DateTime.Parse("Jan 20 2017 11:00AM"),
                    


//                });

//            EmployeeEducations.Add(2,
//               new EmployeeEducation
//               {
//                   EmployeeId = 2,
//                   Department = "HR",
//                   DegreeId = 2,
//                   Degree = "MBA in Information Technology",
//                   Institution = "Preston University USA",
//                   StillStudying = "No",
//                   Confirmation = "Yes",
//                   Notes = "Finish my MBA in PRESTON University USA ",
//                   Thesis = "Driving a startup to middle scale enterprise in the USA",
//                   EntranceDate = DateTime.Parse("Feb 22 2013 12:00AM"),
//                   GraduationDate = DateTime.Parse("Jan 26 2017 12:00AM"),
                


//               });

//            EmployeeEducations.Add(3,
//               new EmployeeEducation
//               {
//                   EmployeeId = 3,
//                   Department = "HR",
//                   DegreeId = 3,
//                   Degree = "MBA in Information Technology",
//                   Institution = "Preston University USA",
//                   StillStudying = "No",
//                   Confirmation = "Yes",
//                   Notes = "Finish my MBA in PRESTON University USA ",
//                   Thesis = "Driving a startup to middle scale enterprise in the USA",
//                   EntranceDate = DateTime.Parse("Feb 22 2014 12:00AM"),
//                   GraduationDate = DateTime.Parse("Jan 28 2017 12:00AM"),
                 


//               });

//            foreach (var employeeedu in EmployeeEducations.Values)
//            {
//                context.EmployeeEducations.Add(employeeedu);

//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployeeEmergencyCalls(AlloeContext context)
//        {
//            EmployeeEmergencyCalls.Add(1,
//                new EmployeeEmergencyCall
//                {
//                    EmployeeId = 1,
//                    Name = "Smuel Akinsosju",
//                    SurName = "Akinsoju",
//                    RelationTo = "MaCalley",
//                    Phone = "+2348060050022"


//                });

//            EmployeeEmergencyCalls.Add(2,
//               new EmployeeEmergencyCall
//               {
//                   EmployeeId = 2,
//                   Name = "Smuel Akinju",
//                   SurName = "Akinju",
//                   RelationTo = "MaCalley",
//                   Phone = "+2348060050022"


//               });

//            EmployeeEmergencyCalls.Add(3,
//               new EmployeeEmergencyCall
//               {
//                   EmployeeId = 3,
//                   Name = "Smuel Akinsosju",
//                   SurName = "Akins",
//                   RelationTo = "MaCalley",
//                   Phone = "+2348060050022"


//               });

//            foreach (var employeeEmerCall in EmployeeEmergencyCalls.Values)
//            {
//                context.EmployeeEmergencyCalls.Add(employeeEmerCall);
//            }
//            context.SaveChanges();
//        }

//        private void SeedEmployeeLanguages(AlloeContext context)
//        {
//            EmployeeLanguages.Add(1,
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

//                });

//            EmployeeLanguages.Add(2,
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

//               });

//            EmployeeLanguages.Add(3,
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

//               });

//            foreach (var employeelang in EmployeeLanguages.Values)
//            { 
//              context.EmployeeLanguages.Add(employeelang);
//            }

//            context.SaveChanges();       
//        }

//        private void SeedEmployeeProjects(AlloeContext context)
//        {
//            EmployeeProjects.Add(1,
//                new EmployeeProject
//                {
//                    EmployeeId = 1,
//                    Name = "Developing a complaints logging system",
//                    Start = DateTime.Parse("July 12 2015 17:00PM"),
//                    Finish = DateTime.Parse("Sept 20 2015 18:00PM"),
//                    Completed = "Yes",
//                    JobPosition = "Software Support",
//                    ProjectId = 1,
//                    Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                    Confirmation = "Yes",

//                });

//            EmployeeProjects.Add(2,
//               new EmployeeProject
//               {
//                   EmployeeId = 2,
//                   Name = "Developing a complaints logging system",
//                   Start = DateTime.Parse("July 12 2015 17:00PM"),
//                   Finish = DateTime.Parse("Sept 22 2015 18:00PM"),
//                   Completed = "Yes",
//                   JobPosition = "Software Developer",
//                   ProjectId = 1,
//                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                   Confirmation = "Yes",

//               });

//            EmployeeProjects.Add(3,
//               new EmployeeProject
//               {
//                   EmployeeId = 3,
//                   Name = "Developing a complaints logging system",
//                   Start = DateTime.Parse("July 12 2015 17:00PM"),
//                   Finish = DateTime.Parse("Sept 20 2015 18:00PM"),
//                   Completed = "No",
//                   JobPosition = "Software Engineer",
//                   ProjectId = 1,
//                   Notes = "The complaint logging system was developed to recieve complaint from customer and employee of the company",
//                   Confirmation = "No",

//               });

//            foreach (var employeeproj in EmployeeProjects.Values)
//            {
//                context.EmployeeProjects.Add(employeeproj);
//            }
//            context.SaveChanges();

//        }

//        private void SeedEmployeeQuits(AlloeContext context)
//        {
//            EmployeeQuits.Add(1,
//                new EmployeeQuit
//                {
//                    EmployeeId = 1,
//                    ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                    ProcessEnd = DateTime.Parse("June 02 2017 23:00PM"),
//                    ApproverId = 1,
//                    CHRAdvance = "30 DAYS",
//                    TrainingCancel = "Yes",
//                    HealthInsurance = "Beneficiary",
//                    CHRNotes = "Good and hardworking, he outperformed our expectation",
//                    CompanyIdCard = "taking back",
//                    PC = "Left in a good shape",
//                    Monitor = "Left in a good condition",
//                    PhoneHeadSet = "taking back",
//                    CioNotes = "No fault was found in him",
//                    CreditCard = "submitted",
//                    GSMCard = "Submitted",
//                    CompanyVehicle = "None",
//                    VehicleEntryStamp = "none",
//                    BookKeepingAdvance = "None",
//                    BANotes = "All due process observed",
//                    Multinet = "Subcription cutoff",
//                    Quit = true,
//                    QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                    QuitReason = "Got another job",
//                    MailSent = "Yes",

//                });

//            EmployeeQuits.Add(2,
//                new EmployeeQuit
//                {
//                    EmployeeId = 2,
//                    ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                    ProcessEnd = DateTime.Parse("June 02 2017 23:00PM"),
//                    ApproverId = 2,
//                    CHRAdvance = "20 DAYS",
//                    TrainingCancel = "No",
//                    HealthInsurance = "Beneficiary",
//                    CHRNotes = "Good and hardworking, he outperformed our expectation",
//                    CompanyIdCard = "taking back",
//                    PC = "Left in a good shape",
//                    Monitor = "Left in a good condition",
//                    PhoneHeadSet = "taking back",
//                    CioNotes = "No fault was found in him",
//                    CreditCard = "submitted",
//                    GSMCard = "Submitted",
//                    CompanyVehicle = "None",
//                    VehicleEntryStamp = "none",
//                    BookKeepingAdvance = "None",
//                    BANotes = "All due process observed",
//                    Multinet = "Subcription cutoff",
//                    Quit = true,
//                    QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                    QuitReason = "Got another job",
//                    MailSent = "Yes",

//                });

//            EmployeeQuits.Add(3,
//                new EmployeeQuit
//                {
//                    EmployeeId = 3,
//                    ProcessBegin = DateTime.Parse("Jan 22 2018 22:00PM"),
//                    ProcessEnd = DateTime.Parse("June 02 2017 23:00PM"),
//                    ApproverId = 3,
//                    CHRAdvance = "12 DAYS",
//                    TrainingCancel = "No",
//                    HealthInsurance = "Beneficiary",
//                    CHRNotes = "Good and hardworking, he outperformed our expectation",
//                    CompanyIdCard = "taking back",
//                    PC = "Left in a good shape",
//                    Monitor = "Left in a good condition",
//                    PhoneHeadSet = "taking back",
//                    CioNotes = "No fault was found in him",
//                    CreditCard = "submitted",
//                    GSMCard = "Submitted",
//                    CompanyVehicle = "None",
//                    VehicleEntryStamp = "none",
//                    BookKeepingAdvance = "None",
//                    BANotes = "All due process observed",
//                    Multinet = "Subcription cutoff",
//                    Quit = true,
//                    QuitDate = DateTime.Parse("May 29 2017 14:00PM"),
//                    QuitReason = "Got another job",
//                    MailSent = "No",

//                });

//            foreach (var employequ in EmployeeQuits.Values)
//            {
//                context.EmployeeQuits.Add(employequ);
//            }
//            context.SaveChanges();
//        }

//        public void SeedEmployeeTechnicalSkills(AlloeContext context)
//        {
//            EmployeeTechnicalSkills.Add(1,
//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 1,
//                    Name = "Microsoft azure Architect",
//                    Level = Level.Advanced,
//                    Confirmation = "Yes",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 1,
//                    LevelId = 1,

//                });

//            EmployeeTechnicalSkills.Add(2,
//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 2,
//                    Name = "Google Cloud Architect",
//                    Level = Level.Beginner,
//                    Confirmation = "No",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 2,
//                    LevelId = 2,

//                });

//            EmployeeTechnicalSkills.Add(1,
//                new EmployeeTechnicalSkill
//                {
//                    EmployeeId = 3,
//                    Name = "Amazon Cloud Architect",
//                    Level = Level.Intermediate,
//                    Confirmation = "Yes",
//                    Notes = "Very qualified to take work in thr position",
//                    SkillId = 3,
//                    LevelId = 3,

//                });

//            foreach (var employeetechski in EmployeeTechnicalSkills.Values)
//            {
//                context.EmployeeTechnicalSkills.Add(employeetechski);
//            }
//            context.SaveChanges();
//        }
            
//        private void SeedEmployeeTrainings(AlloeContext context)
//        {
//            EmployeeTrainings.Add(1,
//                new EmployeeTraining
//                {
//                    EmployeeId = 1,
//                    Name = ".Net Application Developer",
//                    Location = "Lagos",
//                    Duration = "6 month",
//                    Provider = "Microsoft edx",
//                    Confirmation = "Yes",
//                    Start = DateTime.Parse("March 12 2015 12:00AM"),
//                    Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                    Notes = "Very exceptional through the training"
//                });

//            EmployeeTrainings.Add(2,
//               new EmployeeTraining
//               {
//                   EmployeeId = 2,
//                   Name = " Application Developer",
//                   Location = "Lagos",
//                   Duration = "6 month",
//                   Provider = "Microsoft edx",
//                   Confirmation = "Yes",
//                   Start = DateTime.Parse("March 12 2015 12:00AM"),
//                   Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                   Notes = "Very exceptional through the training"
//               });

//            EmployeeTrainings.Add(3,
//               new EmployeeTraining
//               {
//                   EmployeeId = 3,
//                   Name = "java Application Developer",
//                   Location = "abuja",
//                   Duration = "6 month",
//                   Provider = "Microsoft edx",
//                   Confirmation = "Yes",
//                   Start = DateTime.Parse("March 12 2015 12:00AM"),
//                   Finish = DateTime.Parse("Nov 22 2016 13:00PM"),
//                   Notes = "Very exceptional through the training"
//               });
//            foreach (var employeetrain in EmployeeTrainings.Values)
//            {
//                context.EmployeeTrainings.Add(employeetrain);
//            }
//            context.SaveChanges();
//        }

//        private static byte[] StringToByteArray(string hex)
//        {
//            return Enumerable.Range(0, hex.Length)
//                .Where(x => x % 2 == 0)
//                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
//                .ToArray();
//        }

//        //public void SaveImage(string base64String, string filepath)
//        //{
//        //    // image convert to base64string is base64String 
//        //    //File path is which path to save the image.
//        //    var bytess = Convert.FromBase64String(base64String);
//        //    using (var imageFile = new FileStream(filepath, FileMode.Create))
//        //    {
//        //        imageFile.Write(bytess, 0, bytess.Length);
//        //        imageFile.Flush();
//        //    }
//        //}

//    }
//}