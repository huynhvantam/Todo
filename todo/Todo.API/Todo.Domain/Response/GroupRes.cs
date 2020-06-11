using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Response
{
    public class GroupRes
    {
        public int IDG { get; set; }
        public string GroupName { get; set; }
        public int AllTask { get; set; }
        public int STT { get; set; }
    }
}
