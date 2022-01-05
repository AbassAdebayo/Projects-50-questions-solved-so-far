using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlog.Context;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly MyAppContext _categoryContext;

        public CategoryRepository(MyAppContext categoryContext)
        {
            _categoryContext = categoryContext;
        }
        public Category Create(Category category)
        {
            _categoryContext.Add(category);
            _categoryContext.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            _categoryContext.Update(category);
            _categoryContext.SaveChanges();
            return category;
        }

        public Category get(int id)
        {
            return _categoryContext.Categories.Find(id);
            
        }

        public void Delete(Category category)
        {
            _categoryContext.Remove(category);
            _categoryContext.SaveChanges();
        }

        public IEnumerable<Category> GetSelectedCategories(IList<int> Ids)
        {
            return _categoryContext.Categories.Where(x => Ids.Contains(x.Id)).ToList();
        }

        public IList<Category> GetAll()
        {
           return _categoryContext.Categories.ToList();
        }
    }
}