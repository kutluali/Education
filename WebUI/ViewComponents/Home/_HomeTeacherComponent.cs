using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.UserDtos;

namespace WebUI.ViewComponents.Home
{
    public class _HomeTeacherComponent : ViewComponent
    {
        private readonly HttpClient _client;



        public _HomeTeacherComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultUserDto>>("users/Get4Teachers");
            return View(values);
        }
    }
}
