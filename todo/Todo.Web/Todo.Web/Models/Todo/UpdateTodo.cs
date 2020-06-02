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
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }
        public bool Important { get; set; }
        [Display(Name = "Change to Group")]
        public int GroupIDG { get; set; }
        public bool Finish { get; set; }
    }
}
