using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.DTOS;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Controllers
{
    public class BlogController:Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            
            _categoryService = categoryService;
        }
        
        public IActionResult Index()
        {
            var blogs = _blogService.GetAll();
            return View(blogs);
        }
        
        public IActionResult Create()
        {
       
            var categories = _categoryService.GetAllCategories();
            ViewData["Categories"] = new SelectList(categories, "Id", "CategoryName");
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(CreateBlogRequestModel model)
        {
            _blogService.Create(model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var blog = _blogService.GetBlogCategory(id);
            return View(blog);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var blog = _blogService.Get(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(int id, UpdateBlogRequestModel model)
        {
            _blogService.Update(id, model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var blog = _blogService.Get(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _blogService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}