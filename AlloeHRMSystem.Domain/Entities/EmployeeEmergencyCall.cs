using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
    public class EmployeeEmergencyCall
    {
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string RelationTo { get; set; }
        public string Phone { get; set; }

        public Employee Employee { get; set; }

    }
}
