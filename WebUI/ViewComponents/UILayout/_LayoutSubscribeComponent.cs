using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.UILayout
{
    public class _LayoutSubscribeComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
