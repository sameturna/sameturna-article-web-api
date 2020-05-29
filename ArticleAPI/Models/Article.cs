namespace ArticleAPI.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
    }
}