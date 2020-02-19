using AlloeHRMSystem.Domain.Enums;
using AlloeHRMSystem.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
     public class Employee
     {
        public Employee()
        {
            EmployeeAttachments = new HashSet<EmployeeAttachment>();
            EmployeeCertificates = new HashSet<EmployeeCertificate>();
            EmployeeEducations = new HashSet<EmployeeEducation>();
            EmployeeLanguages = new HashSet<EmployeeLanguage>();
            EmployeeTechnicalSkills = new HashSet<EmployeeTechnicalSkill>();
            EmployeeProjects = new HashSet<EmployeeProject>();
            EmployeeTrainings = new HashSet<EmployeeTraining>();
        }
        
        
        public int EmployeeId { get; set; }
       // public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public Dept? Department { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string BloodType { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }
        public string Nationality { get; set; }
        public string HousePhone { get; set; }
        public string ContractType { get; set; }
        public string JobLocation { get; set; }
        public bool IsConfirmed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? QuitDate { get; set; }
        public bool IsLeavedJob { get; set; }
        public DateTime? LeaveJobDate { get; set; }
        public string LeaveJobReason { get; set; }
      
        public string LegalDayOff { get; set; }
       // public virtual AppUser AppUser { get; set; }
        public EmployeeQuit EmployeeQuit { get; set; }
       // public virtual AppUser AppUser { get; set; }
        public ICollection<EmployeeAttachment> EmployeeAttachments { get; set; }
        public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public ICollection<EmployeeTechnicalSkill> EmployeeTechnicalSkills { get; set; }
        public ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
        public ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        public ICollection<EmployeeEmergencyCall> EmployeeEmergencyCalls { get; set; }
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; }

    }
}
