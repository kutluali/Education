using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.UserDtos;

namespace WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class StudentListController : Controller
    {
        private readonly HttpClient _client;

        public StudentListController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var students = await _client.GetFromJsonAsync<List<ResultUserDto>>("users/StudentList");
            return View(students);
        }
    }
}
