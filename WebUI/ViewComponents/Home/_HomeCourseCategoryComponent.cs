﻿using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.CourseCategoryDtos;

namespace WebUI.ViewComponents.Home
{
    public class _HomeCourseCategoryComponent : ViewComponent
    {
        private readonly HttpClient _client;


        public _HomeCourseCategoryComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("courseCategories/GetActiveCategories");
            return View(values);

        }
    }
}
