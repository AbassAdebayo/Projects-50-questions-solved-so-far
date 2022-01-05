using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.DTOS;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Controllers
{
    public class PostController:Controller
    {
        private readonly IPostService _postService;
        private readonly IBlogService _blogService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostController(IPostService postService, IBlogService blogService, IWebHostEnvironment webHostEnvironment)
        {
            _postService = postService;
            _blogService = blogService;
            _webHostEnvironment = webHostEnvironment;

        }
        
        public IActionResult Index()
        {
            var posts = _postService.GetAll();
            return View(posts);
        }

        public IActionResult Create()
        {
            var blogs = _blogService.GetAll();
            ViewData["Blogs"] = new SelectList(blogs, "Id", "Url");
            
            
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(CreatePostRequestModel model, IFormFile postPhoto)
        {
            string postPhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "PostPhoto");
            Directory.CreateDirectory(postPhotoPath);
            string contentType = postPhoto.FileName.Split('.')[1];
            string postImage = $"PST{Guid.NewGuid()}.{contentType}";
            string fullPath = Path.Combine(postPhotoPath, postImage);

            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                postPhoto.CopyTo(fileStream);
            }

            model.PostPhoto = postImage;
            _postService.Create(model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var post = _postService.Get(id);
            
            return View(post);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(int id, UpdatePostRequestModel model)
        {
            _postService.Update(id, model);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _postService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}