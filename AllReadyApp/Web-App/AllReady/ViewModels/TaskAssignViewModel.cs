﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllReady.ViewModels
{
    public class TaskAssignViewModel
    {
        public int ActivityId { get; set; }
        public int TaskId { get; set; }
        public List<string> AssignedUsers { get; set; }
        //public List<string> AssignedUsers { get; set; }
    }
}
