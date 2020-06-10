using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Request
{
    public class CreateListTodo
    {
        public int TodoID { get; set; }
        public string ListName { get; set; }
    }
}
