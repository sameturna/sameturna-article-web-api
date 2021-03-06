using System.ComponentModel.DataAnnotations;

namespace ArticleAPI.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
    }
}