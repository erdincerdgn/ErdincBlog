using ErdincBlog.Entity.DTOs.Categories;


namespace ErdincBlog.Entity.DTOs.Articles
{
    public class ArticleDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public CategoryDTO Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
