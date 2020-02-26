using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Persistence;
using AlloeHRMSystem.Persistence.GenericRepo;
using AlloeHRMSystem.Persistence.IServices;
using EntityFrameworkPaginate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloeHRMSystem.ApplicationServices.AppServices
{
    public class EmployeeService : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly AlloeContext _context;
        public EmployeeService(AlloeContext context) : base(context)
        {
            _context = context;
        }

        public EmployeeAttachment AddEmpAttachment(EmployeeAttachment attachment)
        {
            _context.EmployeeAttachments.Add(attachment);
            _context.SaveChanges();
            return attachment;
        }



        public EmployeeCertificate AddEmpCertificate(EmployeeCertificate certificate)
        {
            _context.EmployeeCertificates.Add(certificate);
            _context.SaveChanges();
            return certificate;
        }

        public EmployeeEducation AddEmpEducation(EmployeeEducation education)
        {
            _context.EmployeeEducations.Add(education);
            _context.SaveChanges();
            return education;
        }

        public EmployeeLanguage AddEmpLanguages(EmployeeLanguage language)
        {
            _context.EmployeeLanguages.Add(language);
            _context.SaveChanges();
            return language;
        }

        public EmployeeProject AddEmpProject(EmployeeProject project)
        {
            _context.EmployeeProjects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public EmployeeEmergencyCall AddEmployeeEmergencyCall(EmployeeEmergencyCall emergency_Call)
        {
            _context.EmployeeEmergencyCalls.Add(emergency_Call);
            _context.SaveChanges();
            return emergency_Call;
        }

        public EmployeeTechnicalSkill AddEmpTechSkill(EmployeeTechnicalSkill technicalSkill)
        {
            _context.EmployeeTechnicalSkills.Add(technicalSkill);
            _context.SaveChanges();
            return technicalSkill;

        }

        public EmployeeTraining AddEmpTraining(EmployeeTraining training)
        {
            _context.EmployeeTrainings.Add(training);
            _context.SaveChanges();
            return training;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        //public EmployeeAttachment UpdateAttachment(EmployeeAttachment attachment)
        //{
        //    var empAttachment = _context.EmployeeAttachments.FirstOrDefault(e => e.EmployeeId == attachment.EmployeeId);

        //    if (empAttachment != null)
        //    {
        //        empAttachment.EmployeeId = attachment.EmployeeId;
        //        empAttachment.FileName = attachment.FileName;
        //        empAttachment.FileId = attachment.FileId;
        //        empAttachment.Notes = attachment.Notes;
        //        empAttachment.URLOnly = attachment.URLOnly;
        //        empAttachment.FileSize = attachment.FileSize;
        //        empAttachment.Confirmation = attachment.Confirmation;
        //        empAttachment.Type = attachment.Type;

        //    }

        //    _context.SaveChanges();
        //    return empAttachment;
        //}

        public Employee UpdateEmployee(Employee employeeEdit)
        {
            var employ = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeEdit.EmployeeId);

            if (employ != null)
            {
                employ.EmployeeId = employeeEdit.EmployeeId;
              //  employ.UserId = employeeEdit.UserId;
                employ.Firstname = employeeEdit.Firstname;
                employ.Lastname = employeeEdit.Lastname;
                employ.Phone = employeeEdit.Phone;
                employ.Email = employeeEdit.Email;
                employ.HomeAddress = employeeEdit.HomeAddress;
                employ.Department = employeeEdit.Department;
                employ.City = employeeEdit.City;
                employ.Country = employeeEdit.Country;
                employ.JobTitle = employeeEdit.JobTitle;
                employ.Rank = employeeEdit.Rank;
                employ.BloodType = employeeEdit.BloodType;
                employ.MaritalStatus = employeeEdit.MaritalStatus;
                employ.DateOfBirth = employeeEdit.DateOfBirth;
                employ.Gender = employeeEdit.Gender;
                employ.PhotoPath = employeeEdit.PhotoPath;
                employ.Nationality = employeeEdit.Nationality;
                employ.HousePhone = employeeEdit.HousePhone;
                employ.ContractType = employeeEdit.ContractType;
                employ.JobLocation = employeeEdit.JobLocation;
                employ.IsConfirmed = employeeEdit.IsConfirmed;
                employ.CreatedBy = employeeEdit.CreatedBy;
                employ.CreateDate = employeeEdit.CreateDate;
                employ.LastModifiedBy = employeeEdit.LastModifiedBy;
                employ.StartDate = employeeEdit.StartDate;
                employ.QuitDate = employeeEdit.QuitDate;
                employ.IsLeavedJob = employeeEdit.IsLeavedJob;
                employ.LeaveJobDate = employeeEdit.LeaveJobDate;
                employ.LeaveJobReason = employeeEdit.LeaveJobReason;
                employ.LegalDayOff = employeeEdit.LegalDayOff;

            }
            _context.SaveChanges();
            return employ;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employees;
        }
       public IEnumerable<Employee> SearchAllEmployee(string searchString)
        {
            
            return _context.Employees.Where( e =>
                    e.Firstname.ToLower().Contains(searchString)
                  || e.Lastname.ToLower().Contains(searchString)
                  || e.JobTitle.ToLower().Contains(searchString)
                  || e.Email.ToLower().Contains(searchString)
            || e.Phone.Contains(searchString));
        }

        // Hr Service start here
        public Employee HrAddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee HrDeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee != null)
            {
                _context.Remove(employee);
            }
            _context.SaveChanges();
            return employee;

        }

        public IEnumerable<Employee> HrGetAllEmployee()
        {
            return _context.Employees;
        }
        public IEnumerable<Employee> HrSearchAllEmployee(string searchString)
        {
            return _context.Employees.Where(e =>
                  e.Firstname.ToLower().Contains(searchString)
                || e.Lastname.ToLower().Contains(searchString)
                || e.JobTitle.ToLower().Contains(searchString)
                || e.Email.ToLower().Contains(searchString)
          || e.Phone.Contains(searchString));
        }

        public Employee HrGetEmployee(int id, string name)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id

            || e.Firstname == name);
        }

        //public Employee GetEmployeeByName(string name)
        //{
        //    var employ = _context.Employees.Find(name);

        //    return employ;
        //}


        //public Page<Employee> GetEmployeeReport(int pageSize, int currentPage, string searchText, int sortBy, string jobPosition, string empDepartment)
        //{
        //    Page<Employee> employees;
        //    var filters = new Filters<Employee>();
        //    filters.Add(!string.IsNullOrEmpty(searchText), x => x.Name.Contains(searchText));
        //    filters.Add(!string.IsNullOrEmpty(jobPosition), x => x.Position.Equals(jobPosition));
        //    filters.Add(!string.IsNullOrEmpty(empDepartment), x => x.Department.Equals(empDepartment));

        //    var sorts = new Sorts<Employee>();

        //    //Example without priority.
        //    //sorts.Add(sortBy == 2, x => x.LoginID);
        //    //sorts.Add(sortBy == 1, x => x.BusinessEntityID);
        //    //sorts.Add(sortBy == 3, x => x.JobTitle);

        //    sorts.Add(sortBy == 3, x => x.Position, false, 1);
        //    sorts.Add(sortBy == 1, x => x.Department, true, 2);
        //    sorts.Add(true, x => x.Name, true, 3);



        //        employees = _context.Employees.Paginate(currentPage, pageSize, sorts, filters);


        //    return employees;
        //}

        public Employee HrUpdateEmployeeData(Employee employeeChange)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeChange.EmployeeId);

            if (employee != null)
            {
                employee.EmployeeId = employeeChange.EmployeeId;
              //  employee.UserId = employeeChange.UserId;
                employee.Firstname = employeeChange.Firstname;
                employee.Lastname = employeeChange.Lastname;
                employee.Phone = employeeChange.Phone;
                employee.Email = employeeChange.Email;
                employee.HomeAddress = employeeChange.HomeAddress;
                employee.Department = employeeChange.Department;
                employee.City = employeeChange.City;
                employee.Country = employeeChange.Country;
                employee.JobTitle = employeeChange.JobTitle;
                employee.Rank = employeeChange.Rank;
                employee.BloodType = employeeChange.BloodType;
                employee.MaritalStatus = employeeChange.MaritalStatus;
                employee.DateOfBirth = employeeChange.DateOfBirth;
                employee.Gender = employeeChange.Gender;
                employee.PhotoPath = employeeChange.PhotoPath;
                employee.Nationality = employeeChange.Nationality;
                employee.HousePhone = employeeChange.HousePhone;
                employee.ContractType = employeeChange.ContractType;
                employee.JobLocation = employeeChange.JobLocation;
                employee.IsConfirmed = employeeChange.IsConfirmed;
                employee.CreatedBy = employeeChange.CreatedBy;
                employee.CreateDate = employeeChange.CreateDate;
                employee.LastModifiedBy = employeeChange.LastModifiedBy;
                employee.StartDate = employeeChange.StartDate;
                employee.QuitDate = employeeChange.QuitDate;
                employee.IsLeavedJob = employeeChange.IsLeavedJob;
                employee.LeaveJobDate = employeeChange.LeaveJobDate;
                employee.LeaveJobReason = employeeChange.LeaveJobReason;
                employee.LegalDayOff = employeeChange.LegalDayOff;
            }
            _context.SaveChanges();
            return employee;
        }

        // Manager Service Start Here

        public IEnumerable<Employee> MaGetAllEmployee()
        {
            return _context.Employees;
        }
        public Employee MaGetEmployee(int id, string name)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id

            || e.Firstname == name || e.Lastname == name || e.Email == name || e.JobTitle == name);
        }

        public IQueryable<Employee> MaQueryAllEmployee(string searchString)
        {
            return _context.Employees.Where(e =>
                  e.Firstname.ToLower().Contains(searchString)
                || e.Lastname.ToLower().Contains(searchString)
                || e.JobTitle.ToLower().Contains(searchString)
                || e.Email.ToLower().Contains(searchString)
          || e.Phone.Contains(searchString));
        }



        public Employee MaUpdateEmployeeData(Employee employeeChange)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeChange.EmployeeId);

            if (employee != null)
            {
                employee.EmployeeId = employeeChange.EmployeeId;
              //  employee.UserId = employeeChange.UserId;
                employee.Firstname = employeeChange.Firstname;
                employee.Lastname = employeeChange.Lastname;
                employee.Phone = employeeChange.Phone;
                employee.Email = employeeChange.Email;
                employee.HomeAddress = employeeChange.HomeAddress;
                employee.Department = employeeChange.Department;
                employee.City = employeeChange.City;
                employee.Country = employeeChange.Country;
                employee.JobTitle = employeeChange.JobTitle;
                employee.Rank = employeeChange.Rank;
                employee.BloodType = employeeChange.BloodType;
                employee.MaritalStatus = employeeChange.MaritalStatus;
                employee.DateOfBirth = employeeChange.DateOfBirth;
                employee.Gender = employeeChange.Gender;
                employee.PhotoPath = employeeChange.PhotoPath;
                employee.Nationality = employeeChange.Nationality;
                employee.HousePhone = employeeChange.HousePhone;
                employee.ContractType = employeeChange.ContractType;
                employee.JobLocation = employeeChange.JobLocation;
                employee.IsConfirmed = employeeChange.IsConfirmed;
                employee.CreatedBy = employeeChange.CreatedBy;
                employee.CreateDate = employeeChange.CreateDate;
                employee.LastModifiedBy = employeeChange.LastModifiedBy;
                employee.StartDate = employeeChange.StartDate;
                employee.QuitDate = employeeChange.QuitDate;
                employee.IsLeavedJob = employeeChange.IsLeavedJob;
                employee.LeaveJobDate = employeeChange.LeaveJobDate;
                employee.LeaveJobReason = employeeChange.LeaveJobReason;
                employee.LegalDayOff = employeeChange.LegalDayOff;

            }
            _context.SaveChanges();
            return employee;
        }

        public class EmployeeDal
        {
            private readonly AlloeContext _context;

            public EmployeeDal(AlloeContext context)
            {
                _context = context;
            }
            public Page<Employee> GetEmployeeReport(int pageSize, int currentPage, string searchText, int sortBy, string jobPosition, string empDepartment)
            {
                Page<Employee> employees;
                var filters = new Filters<Employee>();
                filters.Add(!string.IsNullOrEmpty(searchText), x => x.Firstname.Contains(searchText));
                filters.Add(!string.IsNullOrEmpty(jobPosition), x => x.JobTitle.Equals(jobPosition));
                filters.Add(!string.IsNullOrEmpty(empDepartment), x => x.Department.Equals(empDepartment));

                var sorts = new Sorts<Employee>();

                //Example without priority.
                //sorts.Add(sortBy == 2, x => x.LoginID);
                //sorts.Add(sortBy == 1, x => x.BusinessEntityID);
                //sorts.Add(sortBy == 3, x => x.JobTitle);

                sorts.Add(sortBy == 3, x => x.JobTitle, false, 1);
                sorts.Add(sortBy == 1, x => x.Department, true, 2);
                sorts.Add(true, x => x.Firstname, true, 3);



                employees = _context.Employees.Paginate(currentPage, pageSize, sorts, filters);


                return employees;
            }
        }
    }
}
