using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.SocialMediaDtos;

namespace WebUI.ViewComponents.UILayout
{
    public class _UILayoutSocialMedia : ViewComponent
    {
        private readonly HttpClient _client;


        public _UILayoutSocialMedia(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMedias = await _client.GetFromJsonAsync<List<ResultSocialMediaDto>>("socialMedias");
            return View(socialMedias);
        }
    }
}
