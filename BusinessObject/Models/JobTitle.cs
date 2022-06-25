﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            Employees = new HashSet<Employee>();
        }

        public string JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public string JobTitleDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public override string ToString() {
            return this.JobTitleName; 
        }
    }
}
