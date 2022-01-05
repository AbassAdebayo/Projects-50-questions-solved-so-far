using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using MyBlog.DTOS;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Services
{
    public class PostService:IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        

        public PostService(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }
        public bool Create(CreatePostRequestModel model)
        {
            var post = new Post
            {
                Content = model.Content,
                Title = model.Title,
                BlogId = model.BlogId,
                PostPhoto = model.PostPhoto


            };
            _postRepository.Create(post);
            return true;
        }

        public Post Update(int id, UpdatePostRequestModel model)
        {
            var post = _postRepository.Get(id);
            post.Content = model.Content;
            post.Title = model.Title;
            post.PostPhoto = model.PostPhoto;
            _postRepository.Update(post);
            
            return post;
        }

        public PostDto Get(int id)
        {
            var post = _postRepository.Get(id);
            return new PostDto
            {
                Id = post.Id,
                Content = post.Content,
                Title = post.Title,
                PostPhoto = post.PostPhoto
                
                
            };

        }

        public void Delete(int id)
        {
            var post = _postRepository.Get(id);
            _postRepository.Delete(post);
            
        }

        public IList<PostDto> GetAll()
        {
            return _postRepository.GetAll().Select(p => new PostDto
            {
                Content = p.Content,
                Title = p.Title,
                Id = p.Id,
                BlogName = p.Blog.Url,
                PostPhoto = p.PostPhoto



            }).ToList();
        }
    }
}