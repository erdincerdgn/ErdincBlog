using ErdincBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErdincBlog.Data.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("75c0f7ba-1651-4e90-838b-3d37925e2d5b"),
                Name = "Superadmin",
                NormalizedName = "SUPERADMIN",
                // Birden fazla kişi sistem üzerinde değişiklik yapmaması için ConcurrencyStamp kullanılır.
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id = Guid.Parse("64649499-26bd-411c-a8a7-9d836c9d23ad"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                // Birden fazla kişi sistem üzerinde değişiklik yapmaması için ConcurrencyStamp kullanılır.
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id = Guid.Parse("d0a12845-4cd9-44b5-9f6a-e2d7bfb60687"),
                Name = "User",
                NormalizedName = "USER",
                // Birden fazla kişi sistem üzerinde değişiklik yapmaması için ConcurrencyStamp kullanılır.
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
