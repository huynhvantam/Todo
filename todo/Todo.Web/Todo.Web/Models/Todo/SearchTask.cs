using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Todo
{
    public class SearchTask
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public bool Important { get; set; }
        public DateTime DateCreate { get; set; }
        public int GroupIDG { get; set; }
        public bool Finish { get; set; }
        public int Progress { get; set; }
    }
}
