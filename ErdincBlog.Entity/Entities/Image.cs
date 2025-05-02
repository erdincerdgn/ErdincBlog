using ErdincBlog.Core.Entities;

namespace ErdincBlog.Entity.Entities
{
    public class Image : EntityBase
    {
        public string FileName { get; set; } // Image Name
        public string FileType { get; set; } // .png .jpeg

        public ICollection<Article> Articles { get; set;} // Makaleler
        public ICollection<AppUser> Users { get; set; } // Resimler


    }
}
