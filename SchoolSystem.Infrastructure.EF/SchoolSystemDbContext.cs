using System.Data.Entity;
using SchoolSystem.Domain.Model;

namespace SchoolSystem.Infrastructure.EF
{
    public class SchoolSystemDbContext : System.Data.Entity.DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors).WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID")
                    .MapRightKey("PersonID")
                    .ToTable("CourseInstructor"));
        }

        public DbSet<Person> People { get; set; }

        public DbSet<School> Schools { get; set; }
    }
}