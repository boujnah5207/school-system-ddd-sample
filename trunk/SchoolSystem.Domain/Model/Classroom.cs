namespace SchoolSystem.Domain.Model
{
    public class Classroom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public School School { get; set; }

        public int Capacity { get; set; }
    }
}
