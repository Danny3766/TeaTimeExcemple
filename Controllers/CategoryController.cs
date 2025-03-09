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

        /// <summary>
        /// 新增類別 - 表單頁面
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 新增類別 - 寫入資料到 DB
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(CategoryModel category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
