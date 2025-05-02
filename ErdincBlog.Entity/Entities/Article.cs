using ErdincBlog.Core.Entities;

namespace ErdincBlog.Entity.Entities
{
    public class Article : EntityBase // bir sınıf kalıtım alabiliriz. ama Interfaceler istediğimiz kadar kalıtım alabiliriz.
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0; // Görüntüleme Sayısı

        // Category Entities
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        // Image Entities

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
