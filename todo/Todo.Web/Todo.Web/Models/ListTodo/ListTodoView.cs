using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.ListTodo
{
    public class ListTodoView
    {
        public int IDL { get; set; }
        public string ListName { get; set; }
        public bool Finish { get; set; }
        public int TodoID { get; set; }
    }
}
