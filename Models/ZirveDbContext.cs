using Microsoft.EntityFrameworkCore;
using ZirveBinaYonetimi.Models.Entities;

namespace ZirveBinaYonetimi.Models
{
    public class ZirveDbContext : DbContext
    {
        public ZirveDbContext(DbContextOptions<ZirveDbContext> options) : base(options)
        {
        }

        public DbSet<SiteSettings> SiteSettings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        
        public DbSet<HomeContent> HomeContent { get; set; }
        public DbSet<HomeWhyUsItem> HomeWhyUsItems { get; set; }
        public DbSet<HomeProcessStep> HomeProcessSteps { get; set; }
        
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Additional configurations if needed
            modelBuilder.Entity<PostCategory>()
                .HasKey(pc => new { pc.PostId, pc.CategoryId });
        }
    }
}
