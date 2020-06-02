using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Request
{
    public class UpdateTodoReq
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public bool Important { get; set; }
        public bool Finish { get; set; }

        public int GroupIDG { get; set; }
    }
}
