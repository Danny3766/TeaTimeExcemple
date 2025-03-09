using Microsoft.AspNetCore.Mvc;

namespace TeaTimeExample.Controllers
{
    /// <summary>
    /// 類別清單 Controller
    /// </summary>
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
