using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.UserDtos;
using WebUI.Services.UserServices;

namespace WebUI.Controllers
{
    public class TeacherController: Controller
    {
        private readonly HttpClient _client;

        public TeacherController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _client.GetFromJsonAsync<List<ResultUserDto>>("roleassigns/Teachers");
            return View(teachers);
        }
    }
    
}
