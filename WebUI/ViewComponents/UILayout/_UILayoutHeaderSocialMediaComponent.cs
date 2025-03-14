using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.SocialMediaDtos;

namespace WebUI.ViewComponents.UILayout
{
    public class _UILayoutHeaderSocialMediaComponent : ViewComponent
    {
        private readonly HttpClient _client;


        public _UILayoutHeaderSocialMediaComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSocialMediaDto>>("socialMedias");
            return View(values);
        }
    }
}
