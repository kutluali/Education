using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs.TestimonialDtos;

namespace WebUI.ViewComponents.Home
{
    public class _HomeTestimonialComponent : ViewComponent
    {
        private readonly HttpClient _client;


        public _HomeTestimonialComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials");
            return View(values);
        }
    }
}
