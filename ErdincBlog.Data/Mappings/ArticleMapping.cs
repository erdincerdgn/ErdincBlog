using ErdincBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErdincBlog.Data.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        // Configure Entities
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            // Set Primary Key
            // builder.HasKey(x => x.Id);

            // Title ancak 150 karakterden oluşur.
            // builder.Property(x => x.Title).HasMaxLength(150);
            // Allow Nulls
            // builder.Property(x => x.Title).IsRequired(false);

            // Data Seed

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE MVC - Entity Nasıl Oluşturulur?",
                Content = "Entity Nasıl Oluşturulur? Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo mauris, aliquet ultrices vestibulum vitae, lacinia vitae lectus. Duis ac placerat diam. Suspendisse cursus porta arcu, eu consequat lectus posuere ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla urna felis, venenatis quis mauris sed, suscipit pretium orci. Nullam pretium lectus diam, eget dignissim orci volutpat sit amet. Nullam sed iaculis justo, tempus viverra nunc. In lorem tortor, accumsan vitae quam vitae, condimentum varius ex. Morbi porttitor orci eu suscipit tincidunt. Ut facilisis pulvinar leo ac consequat. Nulla sit amet felis elementum, condimentum ligula at, ultrices orci. Sed quis efficitur felis. Vivamus rutrum mi sit amet diam viverra aliquet. Curabitur tempor lacus justo, gravida egestas metus viverra dictum. Morbi suscipit nulla ut eleifend vestibulum.",
                ViewCount = 61,
                CategoryId = Guid.Parse("8020b791-c3d3-406a-95e0-4834ca3d24d2"),
                ImageId = Guid.Parse("22a93f1f-652e-41fc-b9e4-b9b10fa75e2c"),
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("dc61fa66-e621-4844-8219-945fd9da7867")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "C# - Döngüler",
                Content = "C# - Döngüler Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo mauris, aliquet ultrices vestibulum vitae, lacinia vitae lectus. Duis ac placerat diam. Suspendisse cursus porta arcu, eu consequat lectus posuere ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla urna felis, venenatis quis mauris sed, suscipit pretium orci. Nullam pretium lectus diam, eget dignissim orci volutpat sit amet. Nullam sed iaculis justo, tempus viverra nunc. In lorem tortor, accumsan vitae quam vitae, condimentum varius ex. Morbi porttitor orci eu suscipit tincidunt. Ut facilisis pulvinar leo ac consequat. Nulla sit amet felis elementum, condimentum ligula at, ultrices orci. Sed quis efficitur felis. Vivamus rutrum mi sit amet diam viverra aliquet. Curabitur tempor lacus justo, gravida egestas metus viverra dictum. Morbi suscipit nulla ut eleifend vestibulum.",
                ViewCount = 61,
                CategoryId = Guid.Parse("2b7b786b-f828-4ee7-b0e7-18dd93e7b0c6"),
                ImageId = Guid.Parse("6b5909d6-0381-40ec-964f-06571a6af36a"),
                CreatedBy = "Erdinç Erdoğan",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("66bcf6c7-945a-43a5-9027-447f315c66c0")
            });
        }
    }
}
