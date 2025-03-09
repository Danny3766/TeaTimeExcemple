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
            if (!ModelState.IsValid)
            {
                return View(category); // 若驗證失敗，回 Create 表單頁面，並保留表單輸入的資料
            }

            _db.Categories.Add(category);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// 編輯類別 - 表單頁面
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(id);

            return categoryFromDb is null ? NotFound() : View(categoryFromDb);
        }

        /// <summary>
        /// 編輯類別 - 更新資料到 DB
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(CategoryModel category) 
        {
            if (!ModelState.IsValid)
            {
                return View(category); // 若驗證失敗，回 Edit 表單頁面，並保留表單輸入的資料
            }

            _db.Categories.Update(category);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// 刪除類別 - 表單頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(id);

            return categoryFromDb is null ? NotFound() : View(categoryFromDb);
        }

        /// <summary>
        /// 刪除類別 - 刪除 DB 內的資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCategory(int? id)
        {
            var item = _db.Categories.Find(id);

            if (item is null)
            {
                return NotFound();
            }

            _db.Categories.Remove(item);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
