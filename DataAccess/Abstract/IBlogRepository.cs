﻿using Entity.Entities;

namespace DataAccess.Abstract
{
    public interface IBlogRepository : IRepository<Blog>
    {
        List<Blog> GetBlogsWithCategories();
        List<Blog> GetBlogsByCategoryId(int id);
        Blog GetBlogWithCategory(int id);
        List<Blog> GetBlogsWithCategoriesByWriterId(int id);

        List<Blog> GetLast4BlogsWithCategories();

    }
}
