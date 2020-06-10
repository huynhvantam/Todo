using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Response
{
    public class ListTodoRes
    {
        public int IDL { get; set; }
        public string ListName { get; set; }
        public bool Finish { get; set; }
        public int TodoID { get; set; }

    }
}
