using System.Collections.Generic;
using MyBlog.DTOS;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface IPostService
    {
        bool Create(CreatePostRequestModel model);
        
        Post Update(int id, UpdatePostRequestModel model);

        PostDto Get(int id);

        void Delete(int id);

        IList<PostDto> GetAll();
    }
}