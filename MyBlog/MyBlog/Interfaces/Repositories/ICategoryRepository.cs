using System.Collections.Generic;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Category Create(Category category);
        
        Category Update(Category category);

        Category get(int id);

        void Delete(Category category);

        IEnumerable<Category> GetSelectedCategories(IList<int> Ids);

        IList<Category> GetAll();
    }
}