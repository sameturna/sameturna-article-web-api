using ArticleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArticleAPI.Data
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> opt) : base(opt)
        {
            
        }
        public DbSet<Article> Articles { get; set; }
    }
}