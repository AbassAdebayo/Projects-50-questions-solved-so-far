using System.Collections.Generic;

namespace MyBlog.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        
        public string Url { get; set; }
        
        public int CategoryId { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        
        public ICollection<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();




    }
}