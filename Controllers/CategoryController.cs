using Microsoft.AspNetCore.Mvc;
using TeaTimeExample.Models;

namespace TeaTimeExample.Controllers
{
    /// <summary>
    /// 類別清單 Controller
    /// </summary>
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="db"></param>
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var categoryList = _db.Categories.ToList();
            return View(categoryList);
        }
    }
}
