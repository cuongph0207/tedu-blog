using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduBlog.Core.Domain.Content
{
    [Table("Series")]
    public class Series
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        public required string Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        [Column(TypeName = "varchar(250)")]
        public required string Slug { get; set; }
        public bool IsActive { get; set; }
        public int Sortorder {  get; set; }
        [MaxLength(250)]
        public string? SeoDescription {  get; set; }
        [MaxLength(250)]
        public string? Thumbnail { get; set; }
        public string? Content { get; set; }
        public Guid AuthorUserId {  get; set; }
        public DateTime DateCreated {  get; set; }
    }
}
