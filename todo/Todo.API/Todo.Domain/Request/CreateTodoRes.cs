using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Request
{
    public class CreateTodoReq
    {

        public string TaskName { get; set; }
        public bool Important { get; set; }

        public int GroupIDG { get; set; }
        public int Progress { get; set; }
    }
}
