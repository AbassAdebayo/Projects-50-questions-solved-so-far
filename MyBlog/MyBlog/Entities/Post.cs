using System.Collections.Generic;

namespace MyBlog.Entities
{
    public class Post
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }
        
        public int BlogId { get; set; }
        
        public Blog Blog { get; set; }
        
        public string PostPhoto{ get; set; }
    }
}