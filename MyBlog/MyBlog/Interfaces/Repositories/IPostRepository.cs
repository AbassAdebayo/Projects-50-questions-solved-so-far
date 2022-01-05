using System.Collections.Generic;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface IPostRepository
    {
        Post Create(Post post);
        
        Post Update(Post post);

        Post Get(int id);

        void Delete(Post post);

        List<Post> GetAll();
    }
}