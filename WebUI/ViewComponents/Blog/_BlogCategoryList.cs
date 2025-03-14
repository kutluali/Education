using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.BlogCategoryDtos;
using WebUI.Models;

namespace WebUI.ViewComponents.Blog
{
    public class _BlogCategoryList : ViewComponent
    {
        private readonly HttpClient _client;


        public _BlogCategoryList(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogCategories");

            var blogCategories = (from blogCategory in categoryList
                                  select new BlogCategoryWithCountViewModel
                                  {
                                      CategoryName = blogCategory.Name,
                                      BlogCount = blogCategory.Blogs.Count,
                                      BlogCategoryId = blogCategory.BlogCategoryId
                                  }).ToList();
            return View(blogCategories);
        }
    }
}
