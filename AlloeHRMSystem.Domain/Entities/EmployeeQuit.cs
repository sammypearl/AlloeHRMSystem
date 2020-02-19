using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
    public class EmployeeQuit
    {
        public int? EmployeeId { get; set; }
        public int ApproverId { get; set; }
        public DateTime? ProcessBegin { get; set; }
        public DateTime? ProcessEnd { get; set; }
        public string CHRAdvance { get; set; }
        public string TrainingCancel { get; set; }
        public string HealthInsurance { get; set; }
        public string CHRNotes { get; set; }

        public string CompanyIdCard { get; set; }
        public string PC { get; set; }
        public string Monitor { get; set; }
        public string PhoneHeadSet { get; set; }
        public string CioNotes { get; set; }
        public string CreditCard { get; set; }
        public string GSMCard { get; set; }
        public string CompanyVehicle { get; set; }

        public string VehicleEntryStamp { get; set; }
        public string BookKeepingAdvance { get; set; }
        public string BANotes { get; set; }
        public string Multinet { get; set; }
        public bool Quit { get; set; }
        public DateTime? QuitDate { get; set; }
        public string QuitReason { get; set; }
        public string MailSent { get; set; }

        public Employee Employee { get; set; }
    }
}
