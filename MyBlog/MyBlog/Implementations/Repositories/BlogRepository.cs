using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlog.Context;
using MyBlog.DTOS;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Repositories
{
    public class BlogRepository: IBlogRepository
    {
        private readonly MyAppContext _blogContext;

        public BlogRepository(MyAppContext blogContext)
        {
            _blogContext = blogContext;
        }
        public Blog Create(Blog blog)
        {
            _blogContext.Blogs.Add(blog);
            _blogContext.SaveChanges();
            return blog;
        }

        public Blog Update(Blog blog)
        {
            _blogContext.Update(blog);
            _blogContext.SaveChanges();
            return blog;
        }

        public Blog get(int id)
        {
           return _blogContext.Blogs.Find(id);
        }

        public void Delete(Blog blog)
        {
            _blogContext.Remove(blog);
            _blogContext.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            return _blogContext.Blogs.Include(x=>x.BlogCategories).ThenInclude(s=>s.Category).ToList();
        }

        public BlogDto GetBlogCategory(int id)
        {
            return _blogContext.Blogs.Include(s => s.BlogCategories).ThenInclude(a => a.Category).Where(x => x.Id == id)
                .Select(blog => new BlogDto
                {
                    Url = blog.Url,
                    Categories = blog.BlogCategories.Select(x=>new CategoryDto
                    {
                        CategoryName = x.Category.CategoryName,
                        Description = x.Category.Description
                        
                    }).ToList()
                    

                }).SingleOrDefault();
        }
    }
}