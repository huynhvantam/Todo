using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.ListTodo
{
    public class CreateListTodo
    {
        public int IDL { get; set; }

        public int TodoID { get; set; }
        [Display(Name = "List Name")]
        [Required(ErrorMessage = "Do not empty")]
        [StringLength(maximumLength: 255, MinimumLength = 2, ErrorMessage = "List Name must enter 2> 255 characters")]
        public string ListName { get; set; }
    }
}
