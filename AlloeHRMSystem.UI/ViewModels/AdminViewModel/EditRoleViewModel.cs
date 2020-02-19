using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.AdminViewModel
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage ="Role name is required")]
        public string RoleName { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
        public List<string> Users { get; set; }
    }
}
