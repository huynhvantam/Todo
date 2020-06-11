using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.ListTodo
{
    public class TodoItem
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Todo Name")]
        public string TaskName { get; set; }
        public int GroupIDG { get; set; }

    }
}
