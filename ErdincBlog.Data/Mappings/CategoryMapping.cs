using ErdincBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErdincBlog.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Data Seed
            builder.HasData(new Category
            {
                Id = Guid.Parse("8020b791-c3d3-406a-95e0-4834ca3d24d2"),
                Name = "ASP.NET CORE MVC",
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("2b7b786b-f828-4ee7-b0e7-18dd93e7b0c6"),
                Name = "C#",
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
            
        }
    }
}
