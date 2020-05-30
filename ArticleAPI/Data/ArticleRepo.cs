using System.Collections.Generic;
using System.Linq;
using ArticleAPI.Models;

namespace ArticleAPI.Data
{
    public class ArticleRepo : IArticleRepo
    {
        private readonly ArticleContext _context;

        public ArticleRepo(ArticleContext context)
        {
            _context = context;
        }
        public void CreateArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.Where(x => x.IsDeleted == false).ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public void UpdateArticle(Article article)
        {
            throw new System.NotImplementedException();
        }
    }
}