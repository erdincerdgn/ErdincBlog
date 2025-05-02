using AutoMapper;
using ErdincBlog.Entity.DTOs.Articles;
using ErdincBlog.Entity.Entities;

namespace ErdincBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDTO, Article>().ReverseMap();
            CreateMap<ArticleUpdateDTO, Article>().ReverseMap();

        }
    }
}
