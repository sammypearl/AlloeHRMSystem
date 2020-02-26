using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
    public class EmployeeCertificate
    {
        public int? EmployeeId { get; set; }
        public string Name { get; set; }

        public string Provider { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }

        public Employee Employee { get; set; }

    }
}
