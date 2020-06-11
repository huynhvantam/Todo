using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.ListTodo
{
    public class ListTodoView
    {
        [Display(Name = "ID")]
        public int IDL { get; set; }
        [Display(Name = "List Name")]
        public string ListName { get; set; }
        public bool Finish { get; set; }
        public int TodoID { get; set; }
        public int STT { get; set; }
    }
}
