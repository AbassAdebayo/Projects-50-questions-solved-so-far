using System.Collections.Generic;
using MyBlog.DTOS;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface IBlogService
    {
        bool Create(CreateBlogRequestModel model);
        
        Blog Update(int id,  UpdateBlogRequestModel model);

        Blog Get(int id);

        void Delete(int id);

        IList<BlogDto> GetAll();

        BlogDto GetBlogCategory(int id);
    }
}