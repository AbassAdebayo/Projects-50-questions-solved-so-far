using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlog.Context;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Repositories
{
    public class PostRepository:IPostRepository
    {
        private readonly MyAppContext _postContext;

        public PostRepository(MyAppContext postContext)
        {
            _postContext = postContext;
        }
        public Post Create(Post post)
        {
            _postContext.Posts.Add(post);
            _postContext.SaveChanges();
            return post;
        }

        public Post Update(Post post)
        {
            _postContext.Update(post);
            _postContext.SaveChanges();
            return post;
        }

        public Post Get(int id)
        {
            return _postContext.Posts.Find(id);
        }

        public void Delete(Post post)
        {
            _postContext.Remove(post);
            _postContext.SaveChanges();
        }

        public List<Post> GetAll()
        {
            return _postContext.Posts.Include(p => p.Blog).ToList();
        }
    }
}