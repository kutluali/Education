using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseRegisterRepository : GenericRepository<CourseRegister>, ICourseRegisterRepository
    {
        public CourseRegisterRepository(EducationContext context) : base(context)
        {
        }

        public List<CourseRegister> GetAllWithCourseAndCategory(Expression<Func<CourseRegister, bool>> filter)
        {
            return _context.CourseRegisters.Where(filter).Include(x => x.Course).ThenInclude(x => x.CourseCategory).ToList();
        }
    }
}
