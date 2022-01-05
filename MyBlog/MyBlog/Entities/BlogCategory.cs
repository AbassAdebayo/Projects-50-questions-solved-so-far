using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace MyBlog.Entities
{
    public class BlogCategory
    {
        public int Id { get; set; }
        
        public int CategoryId { get; set; }
        
        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public Category Category { get; set; }
        
        
    }
}