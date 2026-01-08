using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZirveBinaYonetimi.Models.Entities
{
    [Table("HomeContent")]
    public class HomeContent
    {
        [Key]
        public int Id { get; set; }
        public string? HeroTitle { get; set; }
        public string? HeroSubtitle { get; set; }
        public string? HeroButtonText { get; set; }
        public string? HeroButtonLink { get; set; }
        public string? HeroImageUrl { get; set; }
        
        public string? WhyUsTitle { get; set; }
        public string? WhyUsSubtitle { get; set; }
        
        public string? ProcessTitle { get; set; }
        public string? ProcessSubtitle { get; set; }
    }

    [Table("HomeWhyUsItems")]
    public class HomeWhyUsItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? IconClass { get; set; }
        public int SortOrder { get; set; }
    }

    [Table("HomeProcessSteps")]
    public class HomeProcessStep
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? IconClass { get; set; }
        public int StepNumber { get; set; }
    }

    [Table("Pages")]
    public class Page
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Content { get; set; }
        public bool IsActive { get; set; }
    }

    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        
        public ICollection<PostCategory> PostCategories { get; set; } = new List<PostCategory>();
    }

    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Content { get; set; }
        public string? CoverImageUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPublished { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; } = new List<PostCategory>();
    }

    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; } = null!;

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;
    }
}
