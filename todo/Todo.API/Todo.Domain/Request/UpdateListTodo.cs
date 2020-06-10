using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Todo.Domain.Request
{
    public class UpdateListTodo
    {
        public int IDL { get; set; }
        public string ListName { get; set; }
        public int TodoID { get; set; }
    }
}
