using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZirveBinaYonetimi.Models.Entities
{
    [Table("SiteSettings")]
    public class SiteSettings
    {
        [Key]
        public int Id { get; set; }
        public string? LogoUrl { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? MapEmbedCode { get; set; }
        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? FooterText { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
    }

    [Table("Services")]
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = null!;
        [StringLength(200)]
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? IconClass { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
    }

    [Table("Projects")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? MainImageUrl { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool IsActive { get; set; }
        
        public ICollection<ProjectImage> Images { get; set; } = new List<ProjectImage>();
    }

    [Table("ProjectImages")]
    public class ProjectImage
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int SortOrder { get; set; }
        
        [ForeignKey("ProjectId")]
        public Project Project { get; set; } = null!;
    }

    [Table("Leads")]
    public class Lead
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "New"; // New, Contacted, OfferSent
    }

    [Table("Faqs")]
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
