using ErdincBlog.Entity.DTOs.Categories;

namespace ErdincBlog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDTO>> GetAllCategoriesNonDeleted();
    }
}
