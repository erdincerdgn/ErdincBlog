using ErdincBlog.Entity.DTOs.Categories;

namespace ErdincBlog.Entity.DTOs.Articles
{
    public class ArticleAddDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        // Kategoriyi liste olarak alıyoruz
        public IList<CategoryDTO> Categories { get; set; }
    }
}
