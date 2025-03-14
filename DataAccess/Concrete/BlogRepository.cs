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
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(EducationContext context) : base(context)
        {
        }

        public List<Blog> GetBlogsByCategoryId(int id)
        {
            return _context.Blogs.Include(x => x.BlogCategory).Include(x => x.Writer).Where(x => x.BlogCategoryId == id).ToList();
        }

        public List<Blog> GetBlogsWithCategories()
        {
            return _context.Blogs.Include(x => x.BlogCategory).Include(x => x.Writer).ToList();
        }

        public List<Blog> GetBlogsWithCategoriesByWriterId(int id)
        {
            return _context.Blogs.Include(x => x.BlogCategory).Where(x => x.WriterId == id).ToList();
        }

        public Blog GetBlogWithCategory(int id)
        {
            return _context.Blogs.Include(x => x.BlogCategory).Include(x => x.Writer).ThenInclude(x => x.TeacherSocials).FirstOrDefault(x => x.BlogId == id);
        }

        public List<Blog> GetLast4BlogsWithCategories()
        {
            return _context.Blogs.Include(x => x.BlogCategory).OrderByDescending(x => x.BlogId).Take(4).ToList();
        }
    }
}
