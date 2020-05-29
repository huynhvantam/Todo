using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Request
{
    public class UpdateImportantReq
    {
        public int ID { get; set; }

        public bool Important { get; set; }
    }
}
