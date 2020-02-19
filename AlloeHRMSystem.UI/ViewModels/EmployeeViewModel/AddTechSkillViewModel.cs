using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels
{
    public class AddTechSkillViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name = "Skill Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Skill Level")]
        public Level? Level { get; set; }
       
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }

    }
}
