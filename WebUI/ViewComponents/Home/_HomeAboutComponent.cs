﻿using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.AboutDtos;

namespace WebUI.ViewComponents.Home
{
    public class _HomeAboutComponent : ViewComponent
    {
        private readonly HttpClient _client;


        public _HomeAboutComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
            return View(about);
        }
    }
}
