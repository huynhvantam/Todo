using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Group
{
    public class UpdateGroup
    {
        public int IDG { get; set; }
        [Display(Name = "Change Name Group")]
        [Required(ErrorMessage = "Bạn phải nhập Group Name")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Password phải nhập từ 2>50 ký tự")]
        public string GroupName { get; set; }

    }
}
