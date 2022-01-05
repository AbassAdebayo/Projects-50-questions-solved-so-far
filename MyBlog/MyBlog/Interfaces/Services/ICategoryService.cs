using System.Collections.Generic;
using MyBlog.DTOS;
using MyBlog.Entities;

namespace MyBlog.Interfaces.Repositories
{
    public interface ICategoryService
    {
        Category AddCategory(CreateCategoryRequestModel model);
        
        Category UpdateCategory(int id,  UpdateCategoryRequestModel model);

        Category get(int id);

        void DeleteCategory(int id);

        IList<CategoryDto> GetAllCategories();
    }
}