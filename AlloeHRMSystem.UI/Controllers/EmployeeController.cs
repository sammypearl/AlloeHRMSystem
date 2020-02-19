using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Domain.IdentityEntities;
using AlloeHRMSystem.Persistence.IServices;
using AlloeHRMSystem.UI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlloeHRMSystem.UI.Security;
using AlloeHRMSystem.UI.LIB;
using AlloeHRMSystem.UI.ViewModels.EmployeeViewModel;

namespace AlloeHRMSystem.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthorizationService authorizationService;
        private readonly UserManager<AppUser> userManager;

        public EmployeeController(IEmployeeRepository employeeRepository, IWebHostEnvironment hostingEnvironment,
            ILogger<HomeController> logger, IAuthorizationService authorizationService, UserManager<AppUser> userManager)
        {
            _employeeRepository = employeeRepository;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            this.authorizationService = authorizationService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            
              
                Employee employee =  _employeeRepository.GetEmployee(id);

            EmployeeEditViewModel updateEmployeeViewModel = new EmployeeEditViewModel()
            {
                EmployeeId = employee.EmployeeId,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Phone = employee.Phone,
                Email = employee.Email,
                HomeAddress = employee.HomeAddress,
                City = employee.City,
                Country = employee.Country,
                BloodType = employee.BloodType,
                MaritalStatus = employee.MaritalStatus,
                Gender = employee.Gender,
                
                Nationality = employee.Nationality,
                HousePhone = employee.HousePhone,
                JobLocation = employee.JobLocation,
                LegalDayOff = employee.LegalDayOff,
                ExistingPhotoPath = employee.PhotoPath

            };

            return View(updateEmployeeViewModel);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeEditViewModel model)
        {
            if (User.Identity.Name != model.Lastname)
                
            if (ModelState.IsValid)
            {
               
                Employee employee = _employeeRepository.GetEmployee(model.EmployeeId);

                employee.EmployeeId = model.EmployeeId;
                employee.Firstname = model.Firstname;
                employee.Lastname = model.Lastname;
                employee.Phone = model.Phone;
                employee.Email = model.Email;
                employee.HomeAddress = model.HomeAddress;
                employee.City = model.City;
                employee.Country = model.Country;
                employee.BloodType = model.BloodType;
                employee.MaritalStatus = model.MaritalStatus;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Gender = model.Gender;
                employee.Nationality = model.Nationality;
                employee.HousePhone = model.HousePhone;
                employee.JobLocation = model.JobLocation;
                employee.LegalDayOff = model.LegalDayOff;

                if (model.Photo != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images",
                            model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                       
                    }
                    employee.PhotoPath = ProcessUploadedFile(model);
                }

                //if (await User. != employee.AppUser.Id)

                //    return new HttpUnauthorizedResult();

                // return "Personal Info Created Successfully";
                _employeeRepository.UpdateEmployee(employee);

                var successMessage = "Employee Info Updated Successfully. Name: " + employee.Firstname;
                TempData["successAlert"] = successMessage;
                return RedirectToAction(successMessage, "Index");

            }
            return View();
                 
        }
        //var successMessage = "Personal Info Created Successfully. Name: " + personalInfo.FirstName;
        //TempData["successAlert"] = successMessage;
        //            return "Personal Info Created Successfully";

        private string ProcessUploadedFile(CreateEmployeeViewModel create)
        {
            string uniqueFileName = null;
            if (create.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "-" + create.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    create.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(AddProjectViewModel project)
        {
            if (ModelState.IsValid)
            {
                EmployeeProject newEmployee = new EmployeeProject
                {
                    EmployeeId = project.EmployeeId ,
                 
                    Name = project.Name,
                    Start = project.Start,
                    Finish = project.Finish,
                    Completed = project.Completed,
                    JobPosition = project.JobPosition,
                    ProjectId = project.ProjectId,
                    Notes = project.Notes
                };
                _employeeRepository.AddEmpProject(newEmployee);
                var successMessage = "Project Info Created Successfully. Name: " + newEmployee.EmployeeId;
                TempData["successAlert"] = successMessage;
                return RedirectToAction(successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCertificate(AddCertificateViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeCertificate newCertificate = new EmployeeCertificate
                { 
                    EmployeeId = model.EmployeeId,
                    Name = model.Name,
                    Provider = model.Provider,
                 
                    Date = model.Date,
                    Notes = model.Notes
                 
                };
                _employeeRepository.AddEmpCertificate(newCertificate);

                var successMessage = "Certificate Info Updated Successfully. Name: " + newCertificate.EmployeeId;
                TempData["successAlert"] = successMessage;
                return RedirectToAction(successMessage,"");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(AddEducationViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeEducation newEducation = new EmployeeEducation
                {
                    EmployeeId = model.EmployeeId,
                    Department = model.Department,
                    DegreeId = model.DegreeId,
                    Degree = model.Degree,
                    Institution = model.Institution,
                    StillStudying = model.StillStudying,
                 
                    Notes = model.Notes,
                    Thesis = model.Thesis,
                    EntranceDate = model.EntranceDate,
                    GraduationDate = model.GraduationDate

                };
                _employeeRepository.AddEmpEducation(newEducation);

                var successMessage = "Education InfoCreated Successfully. Name: " + newEducation.EmployeeId;
                TempData["successAlert"] = successMessage;
                return RedirectToAction( successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddEmergencyCall()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmergencyCall(AddEmergencyCallViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeEmergencyCall newEmergency = new EmployeeEmergencyCall
                {
                    EmployeeId = model.EmployeeId,
                    Name = model.Name,
                    SurName = model.SurName,
                    RelationTo = model.RelationTo,
                    Phone = model.Phone

                };
                _employeeRepository.AddEmployeeEmergencyCall(newEmergency);

                var successMessage = "EmergencyCall Info Created Successfully. Name: " + newEmergency.EmployeeId;
                TempData["successAlert"] = successMessage;
                return RedirectToAction(successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddLanguage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLanguage(AddLanguageViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeLanguage newLanguage = new EmployeeLanguage
                {
                    EmployeeId = model.EmployeeId,
                    Language = model.Language,
                    WrittenLevel = model.WrittenLevel,
                    SpeakingLevel = model.SpeakingLevel,
                    NativeLang = model.NativeLang,
                    LanguageId = model.LanguageId,
                    Notes = model.Notes
                
                };
                _employeeRepository.AddEmpLanguages(newLanguage);

                var successMessage = "Languages Info Created Successfully. Name: " + newLanguage.EmployeeId;
                TempData["successAlert"] = successMessage;
                return RedirectToAction(successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddTechSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTechSkill(AddTechSkillViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeTechnicalSkill newTechSkill = new EmployeeTechnicalSkill
                {
                    EmployeeId = model.EmployeeId,
                    Name = model.Name,
                    Level = model.Level,
                    Notes = model.Notes,
                    LevelId = model.LevelId,
                    SkillId = model.SkillId
      
                };
                _employeeRepository.AddEmpTechSkill(newTechSkill);

                var successMessage = "TechSkill Info Created Successfully. Name: " + newTechSkill.EmployeeId;
                TempData["successAlert"] = successMessage;
                return View(successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddTraining()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTraining(AddTrainingViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeTraining newTraining = new EmployeeTraining
                {EmployeeId = model.EmployeeId,
                    Name = model.Name,
                    Location = model.Location,
                    Duration = model.Duration,
                    Provider = model.Provider,
                  
                    Start =  model.Start,
                    Finish = model.Finish,
                    Notes = model.Notes
                    

                };
                _employeeRepository.AddEmpTraining(newTraining);

                var successMessage = "Training Info Created Successfully. Name: " + newTraining.EmployeeId;
                TempData["successAlert"] = successMessage;
                return View(successMessage, "");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddAttachment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAttachment(AddAttachmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedAttachment(model);
                EmployeeAttachment newAttachment = new EmployeeAttachment
                {
               
                    FileName = model.FileName,
                    EmployeeId = model.EmployeeId,
                    FileId = model.FileId,
                   
                    Notes = model.Notes,         
                    Type = model.Type,
                    FileSize = model.FileSize,
                    URLOnly = uniqueFileName
                };
                _employeeRepository.AddEmpAttachment(newAttachment);

                var successMessage = "Attachment Info Created Successfully. Name: " + newAttachment.EmployeeId;
                TempData["successAlert"] = successMessage;
                return View(successMessage, "");
            }
            return View();
        }

        private string ProcessUploadedAttachment(AddAttachmentViewModel attach)
        {
            string uniqueFileName = null;
            if (attach.File != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Attached Files");
                uniqueFileName = Guid.NewGuid().ToString() + "-" + attach.File.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    attach.File.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        // HR Functions start here


        [HttpGet]
        public IActionResult HrGetAllEmployee(string searchString)
        {
            var employeesbyhr = _employeeRepository.HrGetAllEmployee();

            if (!String.IsNullOrEmpty(searchString))
            {
                employeesbyhr = employeesbyhr.Where(t => t.Firstname.Contains(searchString)
                    || t.Email.Contains(searchString)
                    || t.Rank.Contains(searchString)
                    || t.JobTitle.Contains(searchString)
                    || t.Phone.Contains(searchString));
            }
            var listingResult = employeesbyhr
                .Select(e => new HrEmployeeIndexViewModel
                {
                    EmployeeId = e.EmployeeId,
                  
                    Firstname = e.Firstname,
                    Lastname = e.Lastname,  
                    Phone = e.Phone,
                    Email = e.Email,
                    HomeAddress = e.HomeAddress,
                    Department = e.Department,
                    City = e.City,
                    Country = e.Country,
                    JobTitle = e.JobTitle,
                    Rank = e.Rank,
                    MaritalStatus = e.MaritalStatus,
                    DateOfBirth = e.DateOfBirth,
                    Gender = e.Gender,
                    Nationality = e.Nationality,
                    CreatedBy = e.CreatedBy,
                    CreateDate = e.CreateDate,
                 
                }).ToList();

            return View(listingResult);
        }

        [HttpGet]
        public ViewResult EmployeeDetail(int id, string name)
        {
            var employee = _employeeRepository.HrGetEmployee(id, name);
            //if (employee == null)
            //{
            //    Response.StatusCode = 404;
            //    return View("EmployeeNotFound", id.Value);
            //}
            var model = new HrEmployeeDetailViewModel
            {
                EmployeeId = employee.EmployeeId,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Phone = employee.Phone,
                Email = employee.Email,
                HomeAddress = employee.HomeAddress,
                Department = employee.Department,
                City = employee.City,
                JobTitle = employee.JobTitle,
                Rank = employee.Rank,
                MaritalStatus = employee.MaritalStatus,
                DateOfBirth = employee.DateOfBirth,
                Gender = employee.Gender,
                Nationality = employee.Nationality,
               
                CreatedBy = employee.CreatedBy,
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult HrCreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HrCreateEmployee(HrCreateViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = new Employee
                {
                    EmployeeId = employee.EmployeeId,
                    Firstname = employee.Firstname,
                    Lastname = employee.Lastname,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    HomeAddress = employee.HomeAddress,
                    Department = employee.Department,
                    City = employee.City,
                    Country = employee.Country,
                    JobTitle = employee.JobTitle,
                    Rank = employee.Rank,

                    BloodType = employee.BloodType,
                    MaritalStatus = employee.MaritalStatus,
                    DateOfBirth = employee.DateOfBirth,
                    Gender = employee.Gender,
                    Nationality = employee.Nationality,
                    HousePhone = employee.HousePhone,
                    ContractType = employee.ContractType,
                    JobLocation = employee.JobLocation,
                    IsConfirmed = employee.IsConfirmed,
                    CreatedBy = employee.CreatedBy,
                    CreateDate = employee.CreateDate,
                    LastModifiedBy = employee.LastModifiedBy,
                    StartDate = employee.StartDate,
                    QuitDate = employee.QuitDate,
                    IsLeavedJob = employee.IsLeavedJob,
                    LeaveJobDate = employee.LeaveJobDate,
                    LeaveJobReason = employee.LeaveJobReason,
                    LegalDayOff = employee.LegalDayOff

                };

                _employeeRepository.HrAddEmployee(newEmployee);
                return RedirectToAction("EmployeeDetails", new { id = newEmployee.EmployeeId });
            }
            return View();
        }

        [HttpGet]
        public ViewResult HrEditEmployee(int id, string name)
        {
            var employee = _employeeRepository.HrGetEmployee(id, name);

            HrUpdateViewModel hrUpdateEmployee = new HrUpdateViewModel()
            {
                EmployeeId = employee.EmployeeId,
               // UserId = employee.UserId,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Phone = employee.Phone,
                Email = employee.Email,
                HomeAddress = employee.HomeAddress,
                Department = employee.Department,
                City = employee.City,
                Country = employee.Country,
                JobTitle = employee.JobTitle,
                Rank = employee.Rank,

                BloodType = employee.BloodType,
                MaritalStatus = employee.MaritalStatus,
                DateOfBirth = employee.DateOfBirth,
                Gender = employee.Gender,
               // PhotoPath = employee.PhotoPath,

                Nationality = employee.Nationality,
                HousePhone = employee.HousePhone,
                ContractType = employee.ContractType,
                JobLocation = employee.JobLocation,
                IsConfirmed = employee.IsConfirmed,
                CreatedBy = employee.CreatedBy,
                CreateDate = employee.CreateDate,
                LastModifiedBy = employee.LastModifiedBy,
                StartDate = employee.StartDate,
                QuitDate = employee.QuitDate,
                IsLeavedJob = employee.IsLeavedJob,
                LeaveJobDate = employee.LeaveJobDate,
                LeaveJobReason = employee.LeaveJobReason,
                LegalDayOff = employee.LegalDayOff,
                ExistingPhotoPath = employee.PhotoPath
            };

            return View(hrUpdateEmployee);
        }

        [HttpPost]
        public IActionResult HrEditEmployee(HrUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.HrGetEmployee(model.EmployeeId, model.Firstname);

                employee.EmployeeId = model.EmployeeId;
               // employee.UserId = model.UserId;
                employee.Firstname = model.Firstname;
                employee.Lastname = model.Lastname;
                employee.Phone = model.Phone;
                employee.Email = model.Email;
                employee.HomeAddress = model.HomeAddress;
                employee.Department = model.Department;
                employee.City = model.City;
                employee.Country = model.Country;
                employee.JobTitle = model.JobTitle;
                employee.Rank = model.Rank;

                employee.BloodType = model.BloodType;
                employee.MaritalStatus = model.MaritalStatus;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Gender = model.Gender;
                employee.Nationality = model.Nationality;
                employee.HousePhone = model.HousePhone;
                employee.ContractType = model.ContractType;
                employee.JobLocation = model.JobLocation;
                employee.IsConfirmed = model.IsConfirmed;
                employee.CreatedBy = model.CreatedBy;
                employee.CreateDate = model.CreateDate;
                employee.LastModifiedBy = model.LastModifiedBy;
                employee.StartDate = model.StartDate;
                employee.QuitDate = model.QuitDate;
                employee.IsLeavedJob = model.IsLeavedJob;
                employee.LeaveJobDate = model.LeaveJobDate;
                employee.LeaveJobReason = model.LeaveJobReason;
                employee.LegalDayOff = model.LegalDayOff;

                _employeeRepository.HrUpdateEmployeeData(employee);

                return RedirectToAction("HrGetAllEmployee");
            }
            return View();


        }

        // Manager Functions Start Here

        public IActionResult MaGetAllEmployee(string searchString)
        {
            var employeesbyma = _employeeRepository.MaGetAllEmployee();

            if (!String.IsNullOrEmpty(searchString))
            {
                employeesbyma = employeesbyma.Where(t => t.Firstname.Contains(searchString)
                    || t.Lastname.Contains(searchString)
                    || t.City.Contains(searchString)
                    || t.Country.Contains(searchString)
                    || t.Phone.Contains(searchString));
            }
            var listingResult = employeesbyma
                .Select(e => new ManagerEmployeeIndexViewModel
                {
                    EmployeeId = e.EmployeeId,
                  //  UserId = e.UserId,
                    Firstname = e.Firstname,
                    Lastname = e.Lastname,
                    Phone = e.Phone,
                    Email = e.Email,
                    HomeAddress = e.HomeAddress,
                    Department = e.Department,
                    City = e.City,
                    Country = e.Country,
                    JobTitle = e.JobTitle,
                    Rank = e.Rank,
                    MaritalStatus = e.MaritalStatus,
                    DateOfBirth = e.DateOfBirth,
                    Gender = e.Gender,
                    Nationality = e.Nationality,
                    CreatedBy = e.CreatedBy,
                    CreateDate = e.CreateDate,
                }).ToList();

            return View(listingResult);
        }

        [HttpGet]
        public ViewResult MaEditEmployee(int id, string name)
        {
            var employee = _employeeRepository.MaGetEmployee(id, name);

            ManagerUpdateViewModel maUpdateEmployee = new ManagerUpdateViewModel()
            {
                EmployeeId = employee.EmployeeId,
              //  UserId = employee.UserId,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Phone = employee.Phone,
                Email = employee.Email,
                HomeAddress = employee.HomeAddress,
                Department = employee.Department,
                City = employee.City,
                Country = employee.Country,
                JobTitle = employee.JobTitle,
                Rank = employee.Rank,

               BloodType = employee.BloodType,
               MaritalStatus = employee.MaritalStatus,
               DateOfBirth = employee.DateOfBirth,
               Gender = employee.Gender,
               Nationality = employee.Nationality,
               HousePhone = employee.HousePhone,
               ContractType = employee.ContractType,
               JobLocation = employee.JobLocation,
               IsConfirmed = employee.IsConfirmed,
               CreatedBy = employee.CreatedBy,
               CreateDate = employee.CreateDate,
               LastModifiedBy = employee.LastModifiedBy,
               StartDate = employee.StartDate,
               QuitDate = employee.QuitDate,
               IsLeavedJob = employee.IsLeavedJob,
               LeaveJobDate = employee.LeaveJobDate,
               LeaveJobReason = employee.LeaveJobReason,
               LegalDayOff = employee.LegalDayOff
            };

            return View(maUpdateEmployee);
        }

        [HttpPost]
        public IActionResult MaEditEmployee(ManagerUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.MaGetEmployee(model.EmployeeId, model.Firstname);

                employee.EmployeeId = model.EmployeeId;
              //  employee.UserId = model.UserId;
                employee.Firstname = model.Firstname;
                employee.Lastname = model.Lastname;
                employee.Phone = model.Phone;
                employee.Email = model.Email;
                employee.HomeAddress = model.HomeAddress;
                employee.Department = model.Department;
                employee.City = model.City;
                employee.Country = model.Country;
                employee.JobTitle = model.JobTitle;
                employee.Rank = model.Rank;
                employee.BloodType = model.BloodType;
                employee.MaritalStatus = model.MaritalStatus;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Gender = model.Gender;
                employee.Nationality = model.Nationality;
                employee.HousePhone = model.HousePhone;
                employee.ContractType = model.ContractType;
                employee.JobLocation = model.JobLocation;
                employee.IsConfirmed = model.IsConfirmed;
                employee.CreatedBy = model.CreatedBy;
                employee.CreateDate = model.CreateDate;
                employee.LastModifiedBy = model.LastModifiedBy;
                employee.StartDate = model.StartDate;
                employee.QuitDate = model.QuitDate;
                employee.IsLeavedJob = model.IsLeavedJob;
                employee.LeaveJobDate = model.LeaveJobDate;
                employee.LeaveJobReason = model.LeaveJobReason;
                employee.LegalDayOff = model.LegalDayOff;

                _employeeRepository.MaUpdateEmployeeData(employee);

                return RedirectToAction("MaGetAllEmployee");
            }
            return View();

        }

        //[HttpPost]
        //public IActionResult GetReportData()
        //{
        //    try
        //    {
        //        var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
        //        var start = Request.Form["start"].FirstOrDefault();
        //        var length = Request.Form["length"].FirstOrDefault();

        //        var sortColumn = Request.Form["columns[" +
        //               Request.Form["order[0][column]"]
        //               .FirstOrDefault() + "][name]"]
        //               .FirstOrDefault();
        //        var sortColumnAscDesc = Request.Form["order[0][dir]"].FirstOrDefault();
        //        var searchValue = Request.Form["search[value]"].FirstOrDefault();

        //        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        //        int skip = start != null ? Convert.ToInt32(start) : 0;
        //        int resultTotal = 0;

        //        var employeeInfoData = (from tblObj in _employeeRepository.GetAll()
        //                                select tblObj);

        //        //Sorting
        //        if (!(string.IsNullOrEmpty(sortColumn) &&
        //                   string.IsNullOrEmpty(sortColumnAscDesc)))
        //        {
        //            employeeInfoData = _employeeRepository.GetAll()
        //                .OrderBy(sortColumn + " " + sortColumnAscDesc);
        //        }

        //        //Search
        //        if (!string.IsNullOrEmpty(searchValue))
        //        {
        //            employeeInfoData = employeeInfoData.Where
        //                         (t => t.Lastname.Contains(searchValue)
        //            || t.Firstname.Contains(searchValue)
        //            || t.Phone.Contains(searchValue)
        //            || t.JobTitle.Contains(searchValue)
        //            || t.Email.Contains(searchValue)
        //            || t.Gender.Contains(searchValue));
        //        }

        //        resultTotal = employeeInfoData.Count();
        //        var result = employeeInfoData.Skip(skip).Take(pageSize).ToList();
        //        return Json(new
        //        {
        //            draw = draw,
        //            recordsFiltered = resultTotal,
        //            recordsTotal = resultTotal,
        //            data = result
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public IActionResult AddEditEmployeeInfo(int id)
        {
            Employee employeeInfo = new Employee();
            if (id != 0) employeeInfo = _employeeRepository.Find(b => b.EmployeeId == id);
            return PartialView("_EmployeeInfoForm", employeeInfo);
        }

        public FileStreamResult ExportAllDatatoCSV()
        {
            var employeeInfoData = (from tblObj in
                  _employeeRepository.GetAllEmployee()
                                    select tblObj).Take(100);
            var result = Common.WriteCsvToMemory(employeeInfoData);
            var memoryStream = new MemoryStream(result);
            return new FileStreamResult(memoryStream, "text/csv")
            { FileDownloadName = "Employee_Info_Data.csv" };
        }
    }
}