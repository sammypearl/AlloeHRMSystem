using AlloeHRMSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class EmployeeEditViewModel : CreateEmployeeViewModel
    {
      
        public int EmployeeId { get; set; }
        
      //  public string UserId { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ExistingPhotoPath { get; set; }
    }
}
