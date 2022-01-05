using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyBlog.Entities;

namespace MyBlog.DTOS
{
    public class CategoryDto
    {
        public int Id { get; set; }
        
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<BlogDto> Blogs { get; set; }
    }

    public class CreateCategoryRequestModel
    {   
        [Required(ErrorMessage = "Category name required!")]
        public string CategoryName { get; set; }
        
        [Required(ErrorMessage = "The field must not be empty")]
        public string Description { get; set; }
    }
    
    public class UpdateCategoryRequestModel
    {
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
    }
}