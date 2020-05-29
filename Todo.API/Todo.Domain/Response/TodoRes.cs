using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Response
{
    public class TodoRes
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public bool Important { get; set; }
        //public DateTime DateCreate { get; set; }
        public int GroupIDG { get; set; }
    }
}
