using AutoMapper;
using ErdincBlog.Data.UnitofWorks;
using ErdincBlog.Entity.DTOs.Articles;
using ErdincBlog.Entity.Entities;
using ErdincBlog.Service.Services.Abstractions;

namespace ErdincBlog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDTO articleAddDTO)
        {
            var userId = Guid.Parse("dc61fa66-e621-4844-8219-945fd9da7867");

            var article = new Article
            {
                Title = articleAddDTO.Title,
                Content = articleAddDTO.Content,
                CategoryId = articleAddDTO.CategoryId,
                UserId = userId
            };

            await unitofWork.GetRepository<Article>().AddAsync(article);
            await unitofWork.SaveAsync();
        }

        public async Task<List<ArticleDTO>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            
            var articles = await unitofWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDTO>>(articles);
            return map;
        }

        public async Task<ArticleDTO> GetArticleWithCategoryNonDeletedAsync(Guid articleID)
        {

            var article = await unitofWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleID, x => x.Category);
            var map = mapper.Map<ArticleDTO>(article);
            return map;
        }
    }
}
