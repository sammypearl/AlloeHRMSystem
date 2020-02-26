using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class AddLanguageViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name ="Language Name")]
        public string Language { get; set; }
        [Required]
        public Level? WrittenLevel { get; set; }
        [Required]
        public Level? SpeakingLevel { get; set; }
        public string NativeLang { get; set; }

        public int LanguageId { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
       

    }
}
