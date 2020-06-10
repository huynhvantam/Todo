using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Todo
{
    public class TodoView
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        public bool Important { get; set; }
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreate { get; set; }

        public int GroupIDG { get; set; }

        public bool Finish { get; set; }

        public int Progress { get; set; }
        public int AllList { get; set; }
        public int AllListFinish { get; set; }

    }
}
