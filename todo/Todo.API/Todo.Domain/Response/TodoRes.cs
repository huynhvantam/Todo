﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Response
{
    public class TodoRes
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public bool Important { get; set; }
        public DateTime DateCreate { get; set; }
        public int GroupIDG { get; set; }
        public bool Finish { get; set; }
        public int Progress { get; set; }
        public int AllList { get; set; }
        public int AllListFinish { get; set; }
        public int STT { get; set; }
    }
}
