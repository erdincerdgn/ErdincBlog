using ErdincBlog.Entity.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincBlog.Entity.DTOs.Articles
{
    public class ArticleUpdateDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        // Kategoriyi liste olarak alıyoruz
        public IList<CategoryDTO> Categories { get; set; }
    }
}
