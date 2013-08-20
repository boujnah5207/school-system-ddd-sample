using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Domain.Model;
using SchoolSystem.Repository;

namespace SchoolSystem.Service
{
    public class SchoolService
    {
        public IEnumerable<School> GetSchools()
        {
            var repo = new SchoolRepository();
            return repo.GetSchools();
        }
    }
}
