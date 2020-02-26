using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Domain.Entities
{
    public class EmployeeTechnicalSkill
    {
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public Level? Level { get; set; }
        public string Notes { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }

        public Employee Employee { get; set; }

    }
}
