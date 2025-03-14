using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class TeacherLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
