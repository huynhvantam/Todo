﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Web.Models.Group
{
    public class GroupView
    {
        public int IDG { get; set; }
        [Display(Name = "Group Name")]

        public string GroupName { get; set; }
    }
}
