using ErdincBlog.Entity.DTOs.Articles;
using ErdincBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ErdincBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDTO { Categories = categories });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDTO articleAddDTO)
        {

            await articleService.CreateArticleAsync(articleAddDTO);
            RedirectToAction("Index","Article",new {Area = "Admin"});

            // Validation için bu komutun bulunması gerekiyor.
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDTO { Categories = categories });
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid articleID)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(articleID);

            return View(article);
        }
    }
}
