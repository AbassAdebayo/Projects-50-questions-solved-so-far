using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyBlog.Entities;

namespace MyBlog.DTOS
{
    public class BlogDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public List<Post> Posts { get; set; }
        
        public int CategoryId { get; set; }
        
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        
    }


    public class CreateBlogRequestModel
    {
        [DataType(DataType.Url, ErrorMessage = "Please enter a valid Url")]
        public string Url { get; set; }
        
        public IList<int> Categories { get; set; } = new List<int>();
        


    }
    
    public class UpdateBlogRequestModel
    {
        public string Url { get; set; }
    }
}
