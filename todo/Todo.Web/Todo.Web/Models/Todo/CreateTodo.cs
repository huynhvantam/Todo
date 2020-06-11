using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Todo
{
    public class CreateTodo
    {
        [Display(Name = "Todo Name")]
        [Required(ErrorMessage = "Do not empty")]
        [StringLength(maximumLength: 255, MinimumLength = 2, ErrorMessage = "Todo Name must enter 2> 255 characters")]
        public string TaskName { get; set; }
        public bool Important { get; set; }
        [Display(Name = "Add to Group")]
        public int GroupIDG { get; set; }
    }
}
