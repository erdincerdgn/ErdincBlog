using ErdincBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErdincBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole 
            { 
                UserId = Guid.Parse("dc61fa66-e621-4844-8219-945fd9da7867"),
                RoleId = Guid.Parse("75c0f7ba-1651-4e90-838b-3d37925e2d5b")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("66bcf6c7-945a-43a5-9027-447f315c66c0"),
                RoleId = Guid.Parse("64649499-26bd-411c-a8a7-9d836c9d23ad")
            });
        }
    }
}
