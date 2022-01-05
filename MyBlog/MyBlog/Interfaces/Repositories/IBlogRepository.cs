using System.Collections.Generic;
using MyBlog.DTOS;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface IBlogRepository
    {
        Blog Create(Blog blog);
        
        Blog Update(Blog blog);

        Blog get(int id);

        void Delete(Blog blog);

        List<Blog> GetAll();

        BlogDto GetBlogCategory(int id);
    }
}