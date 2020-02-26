using AlloeHRMSystem.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class AddAttachmentViewModel
    {
     
        [Required]
        public string FileName { get; set; }
        public int? EmployeeId { get; set; }
        public int FileId { get; set; }

        public string URLOnly { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        public int FileSize { get; set; }
       
        public FileType Type { get; set; }
        public IFormFile File { get; set; }

    }
}
