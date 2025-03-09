using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// 新增類別
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        } 
    }
}
