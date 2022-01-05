using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyBlog.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        public string CategoryName { get; set; }
        
        public string Description { get; set; }

        public ICollection<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();
    }
}