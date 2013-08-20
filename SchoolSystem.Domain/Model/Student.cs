using System;

namespace SchoolSystem.Domain.Model
{
    public class Student : Person
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}
