using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.ContactDtos;

namespace WebUI.ViewComponents.UILayout
{
    public class _UILayoutHeaderContactInfoComponent : ViewComponent
    {
        private readonly HttpClient _client;


        public _UILayoutHeaderContactInfoComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
            return View(values);
        }
    }
}
