﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.UserDtos;

namespace WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class TeacherListController : Controller
    {
        private readonly HttpClient _client;

        public TeacherListController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _client.GetFromJsonAsync<List<ResultUserDto>>("users/TeacherList");
            return View(teachers);
        }
    }
}
