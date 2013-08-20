using System;

namespace SchoolSystem.Domain.Model
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int? Age
        {
            get
            {
                if (!BirthDate.HasValue)
                    return null;

                DateTime today = DateTime.Today;
                int age = today.Year - this.BirthDate.Value.Year;
                if (this.BirthDate.Value > today.AddYears(-age))
                    age--;

                return age;
            }
        }
    }
}
