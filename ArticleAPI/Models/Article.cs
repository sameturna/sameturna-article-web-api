using System.ComponentModel.DataAnnotations;

namespace ArticleAPI.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}