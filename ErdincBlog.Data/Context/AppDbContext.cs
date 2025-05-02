using ErdincBlog.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; // EF Core
using System.Reflection;

namespace ErdincBlog.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken> // EF Core Class
    {
        protected AppDbContext()
        {
        }

        // AppDbContext Constructor with options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // SQL Server Table ismini çoğul yapmak için kodlar Article -> Articles
        
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        // Model oluşturulmadan önce yapacağımız konfigürasyonlar
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Migration sırasında Identity nedenli hata almamak için yazılır.
            base.OnModelCreating(builder);
            // Entity'ye buradan müdahale edebiliriz. Clean Arch ile kodladığımız için burada kullanmamız doğru olmaz.
            // modelBuilder.Entity<Article>().Property(x => x.Title).HasMaxLength(150);
            // IEntityTypeConfiguration arayüzünden kalıtım alan tüm mapping sınıflarının tanımlanmalarını sağlar.
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
