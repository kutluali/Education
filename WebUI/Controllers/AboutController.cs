﻿using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.AboutDtos;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly HttpClient _client;

        public AboutController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
            return View(values);
        }
    }
}
