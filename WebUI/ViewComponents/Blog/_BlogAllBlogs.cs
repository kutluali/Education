﻿using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.BlogDtos;

namespace WebUI.ViewComponents.Blog
{
    public class _BlogAllBlogs : ViewComponent
    {
        private readonly HttpClient _client;


        public _BlogAllBlogs(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogDto>>("blogs");
            return View(values);

        }
    }
}
