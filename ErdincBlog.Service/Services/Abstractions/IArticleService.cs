using ErdincBlog.Entity.DTOs.Articles;
using ErdincBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDTO>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<ArticleDTO> GetArticleWithCategoryNonDeletedAsync(Guid articleID);
        Task CreateArticleAsync(ArticleAddDTO articleAddDTO);
    }
}
