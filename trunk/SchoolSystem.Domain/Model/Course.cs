using System;
using System.Collections.Generic;

namespace SchoolSystem.Domain.Model
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Subject Subjects { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public School School { get; set; }

        public ushort Workload { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
    }
}
