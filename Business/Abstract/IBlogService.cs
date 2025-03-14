using Entity.Entities;

namespace Business.Abstract
{
    public interface IBlogService: IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
        public List<Blog> TGetBlogsByCategoryId(int id);
        public Blog TGetBlogWithCategory(int id);
        List<Blog> TGetLast4BlogsWithCategories();

        List<Blog> TGetBlogsWithCategoriesByWriterId(int id);

    }
}
