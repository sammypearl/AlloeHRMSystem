using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels
{
    public class AddCertificateViewModel
    {
        public int? EmployeeId { get; set; }
        [Required]
        [Display(Name = "Certificate Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Certificate Provider")]
        public string Provider { get; set; }
       
        [Required]
        [Display(Name ="Issued Date")]
        public DateTime? Date { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

    }
}
