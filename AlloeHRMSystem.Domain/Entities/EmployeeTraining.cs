using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
    public class EmployeeTraining
    {
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Provider { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public string Notes { get; set; }

        public Employee Employee { get; set; }
    }
}
