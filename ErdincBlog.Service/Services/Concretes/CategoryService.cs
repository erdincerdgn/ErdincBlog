using AutoMapper;
using ErdincBlog.Data.UnitofWorks;
using ErdincBlog.Entity.DTOs.Categories;
using ErdincBlog.Entity.Entities;
using ErdincBlog.Service.Services.Abstractions;

namespace ErdincBlog.Service.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitofWork unitofWork,IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryDTO>> GetAllCategoriesNonDeleted()
        {
            // Kategori Döner.
            var categories = await unitofWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            // Maplanmiş Kategori Döner.
            var map = mapper.Map<List<CategoryDTO>>(categories);

            return map;
        }
    }
}
