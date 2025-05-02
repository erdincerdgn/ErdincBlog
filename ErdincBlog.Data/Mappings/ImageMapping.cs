using ErdincBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErdincBlog.Data.Mappings
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        // Data Seed
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("22a93f1f-652e-41fc-b9e4-b9b10fa75e2c"),
                FileName = "img/ornek",
                FileType = "jpg",
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("6b5909d6-0381-40ec-964f-06571a6af36a"),
                FileName = "img/c-sharp-test",
                FileType = "png",
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
            
        }
    }
}
