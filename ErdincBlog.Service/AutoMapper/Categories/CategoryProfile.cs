using AutoMapper;
using ErdincBlog.Entity.DTOs.Categories;
using ErdincBlog.Entity.Entities;

namespace ErdincBlog.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }
}
