using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Request
{
    public class FinishCheckboxReq
    {
        public int ID { get; set; }


        public bool Finish { get; set; }
    }
}
