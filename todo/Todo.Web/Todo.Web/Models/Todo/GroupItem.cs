using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Todo
{
    public class GroupItem
    {
        public int IDG { get; set; }
        [Display(Name = "Group Name")]

        public string GroupName { get; set; }
    }
}
