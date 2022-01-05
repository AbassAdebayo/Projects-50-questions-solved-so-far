using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities;

namespace MyBlog.DTOS
{
    public class PostDto
    {
         public int Id { get; set; }
                
                public string Title { get; set; }
                
                public string Content { get; set; }
                
                public int  BlogId { set; get; }
                
                public string BlogName { get; set; }

                public IList<int> BlogIds { get; set; } = new List<int>();
                
                public IList<CategoryDto> Categories { get; set; }
                
                public string PostPhoto { get; set; }
        
    }

    public class CreatePostRequestModel
    {
        [Required]
        public string Title { get; set; }
        [Required]   
        public string Content { get; set; }
        public int BlogId { get; set; }
        
        [Required]
        public string PostPhoto { get; set; }
        
         
    }
    
    public class UpdatePostRequestModel
    {
        public string Title { get; set; }
                
        public string Content { get; set; }
        
        public string PostPhoto { get; set; }
        
    }
    
}