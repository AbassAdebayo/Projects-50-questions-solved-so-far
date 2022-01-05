using System.Collections.Generic;
using System.Linq;
using MyBlog.Context;
using MyBlog.DTOS;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Services
{
    public class BlogService:IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly ICategoryRepository _categoryRepository;
       

        public BlogService(IBlogRepository blogRepository , ICategoryRepository categoryRepository)
        {
            _blogRepository = blogRepository;
            _categoryRepository = categoryRepository;


        }

        
        public bool Create(CreateBlogRequestModel model)
        {
            var blog = new Blog
            {
                Url = model.Url
                

            };

            var categories = _categoryRepository.GetSelectedCategories(model.Categories);

            foreach (var category in categories)
            {
                var blogCategory = new BlogCategory
                {
                    Blog = blog,
                    BlogId = blog.Id,
                    Category = category,
                    CategoryId = category.Id
                };
                blog.BlogCategories.Add(blogCategory);
            }
            _blogRepository.Create(blog);
            return true;
        }

        public Blog Update(int id, UpdateBlogRequestModel model)
        {
            var blog = _blogRepository.get(id);
            blog.Url = model.Url;
            _blogRepository.Update(blog);
            return blog;
        }

        public Blog Get(int id)
        {
            var blog = _blogRepository.get(id);
            return new Blog
            {
                Id = blog.Id,
                Posts = blog.Posts,
                Url = blog.Url

            };

        }

        public void Delete(int id)
        {
            var blog = _blogRepository.get(id);
            _blogRepository.Delete(blog);
        }

        public IList<BlogDto> GetAll()
        {
            return _blogRepository.GetAll().Select(b => new BlogDto
            {
                Url = b.Url,
                Id = b.Id


            }).ToList();
        }

        public BlogDto GetBlogCategory(int id)
        {
            return _blogRepository.GetBlogCategory(id);
        }
    }
}