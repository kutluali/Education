using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogCategoryRepository : GenericRepository<BlogCategory>, IBlogCategoryRepository
    {
        public BlogCategoryRepository(EducationContext context) : base(context)
        {
        }

        public List<BlogCategory> GetCategoriesWithBlogs()
        {
            return _context.BlogCategories.Include(x => x.Blogs).ToList();
        }
    }
}
