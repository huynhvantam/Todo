using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Group
{
    public class CreateGroup
    {
        [Display(Name = "Group Name")]
        [Required(ErrorMessage = "Bạn phải nhập Group Name")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Password phải nhập từ 2>50 ký tự")]
        public string GroupName { get; set; }
    }
}
