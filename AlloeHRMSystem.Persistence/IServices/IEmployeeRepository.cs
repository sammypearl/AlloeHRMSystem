using AlloeHRMSystem.Domain.Entities;
using AlloeHRMSystem.Persistence.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlloeHRMSystem.Persistence.IServices
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Employee UpdateEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
        EmployeeProject AddEmpProject(EmployeeProject project);
        
        EmployeeTechnicalSkill AddEmpTechSkill(EmployeeTechnicalSkill technicalSkill);
     
        EmployeeEducation AddEmpEducation(EmployeeEducation education);
      
        EmployeeLanguage AddEmpLanguages(EmployeeLanguage language);
     
        EmployeeTraining AddEmpTraining(EmployeeTraining training);
        
        EmployeeCertificate AddEmpCertificate(EmployeeCertificate certificate);
 
        EmployeeEmergencyCall AddEmployeeEmergencyCall(EmployeeEmergencyCall emergency_Call);
 
        EmployeeAttachment AddEmpAttachment(EmployeeAttachment attachment);
       

        // Repository for Manager

        Employee MaGetEmployee(int id, string name);
        IEnumerable<Employee> MaGetAllEmployee();
        IQueryable<Employee> MaQueryAllEmployee();

        Employee MaUpdateEmployeeData(Employee employeeChange);

        // Repository for HR
        Employee HrGetEmployee(int id, string name);
        // Employee GetEmployeeByName(string name);
        IEnumerable<Employee> HrGetAllEmployee();
        Employee HrAddEmployee(Employee employee);
        Employee HrUpdateEmployeeData(Employee employeeChange);
        // Employee GetEmployeeReport(int pageSize, int currentPage, string searchText, int sortBy, string jobPosition, string empDepartment);


        Employee HrDeleteEmployee(int id);
    }
}
