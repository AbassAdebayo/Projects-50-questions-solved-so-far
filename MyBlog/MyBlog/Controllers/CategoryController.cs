using Microsoft.AspNetCore.Mvc;
using MyBlog.DTOS;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var category = _categoryService.GetAllCategories();
            return View(category);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(CreateCategoryRequestModel model)
        {
            _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = _categoryService.get(id);
            return View(category);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryService.get(id);
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(int id, UpdateCategoryRequestModel model)
        {
            _categoryService.UpdateCategory(id, model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var category = _categoryService.get(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }

    }
}
    
   