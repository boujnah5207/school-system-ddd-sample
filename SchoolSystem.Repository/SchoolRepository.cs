using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Domain.Model;

namespace SchoolSystem.Repository
{
    public class SchoolRepository
    {
        public IEnumerable<School> GetSchools()
        {
            var context = new SchoolSystem.Infrastructure.EF.SchoolSystemDbContext();
           return context.Schools.ToList();
        }
    }
}
