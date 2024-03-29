﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Domain.Model
{
    public class Instructor : Person
    {
        public DateTime? HireDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
