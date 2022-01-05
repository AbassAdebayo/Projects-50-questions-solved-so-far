using System.Collections.Generic;
using System.Linq;
using MyBlog.DTOS;
using MyBlog.Entities;
using MyBlog.Interfaces.Repositories;

namespace MyBlog.Implementations.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            
        }


        public Category AddCategory(CreateCategoryRequestModel model)
        {
            var category = new Category
            {
                Description = model.Description,
                CategoryName = model.CategoryName
            };
            _categoryRepository.Create(category);
            
            return category;
        }

        public Category UpdateCategory(int id, UpdateCategoryRequestModel model)
        {
            var category = _categoryRepository.get(id);
            category.Description = model.Description;
            category.CategoryName = model.CategoryName;
            _categoryRepository.Update(category);
            return category;
        }

        public Category get(int id)
        {
            var category= _categoryRepository.get(id);
            return new Category
            {
                Id = category.Id,
                Description = category.Description,
                CategoryName = category.CategoryName,
               

            };
        }

        public void DeleteCategory(int id)
        {
            var category = _categoryRepository.get(id);
            _categoryRepository.Delete(category);
        }

        public IList<CategoryDto> GetAllCategories()
        {
            return _categoryRepository.GetAll().Select(x => new CategoryDto
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.Id

            }).ToList();


        }
    }
}