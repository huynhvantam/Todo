using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Todo
{
    public class UpdateTodo
    {
        public int ID { get; set; }
        [Display(Name = "Todo Name")]
        [Required(ErrorMessage = "Do not empty")]
        [StringLength(maximumLength: 255, MinimumLength = 2, ErrorMessage = "Task Name must enter 2> 255 characters")]
        public string TaskName { get; set; }
        public bool Important { get; set; }
        [Display(Name = "Change to Group")]
        public int GroupIDG { get; set; }
        public bool Finish { get; set; }
    }
}
