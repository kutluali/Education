using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.ContactDtos;
using WebUI.DTOs.MessageDtos;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly HttpClient _client;

        public ContactController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> IndexAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
            ViewBag.map = values.Select(x => x.MapUrl).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto model)
        {
            await _client.PostAsJsonAsync("messages", model);
            return NoContent();
        }


    }
}
