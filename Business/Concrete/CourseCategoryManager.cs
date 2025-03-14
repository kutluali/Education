using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseCategoryManager : GenericManager<CourseCategory>, ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _courseCategoryRepository;
        public CourseCategoryManager(IRepository<CourseCategory> _repository, ICourseCategoryRepository courseCategoryRepository) : base(_repository)
        {
            _courseCategoryRepository = courseCategoryRepository;
        }

        public void TDontShowOnHome(int id)
        {
            _courseCategoryRepository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseCategoryRepository.ShowOnHome(id);
        }
    }
}
