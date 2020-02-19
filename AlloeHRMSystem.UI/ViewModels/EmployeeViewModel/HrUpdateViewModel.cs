using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.EmployeeViewModel
{
    public class HrUpdateViewModel : HrCreateViewModel
    {
        public int EmployeeId { get; set; }
        [DataType(DataType.ImageUrl)]
       // public string UserId { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
