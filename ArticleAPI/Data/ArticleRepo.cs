using System;
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
            if(article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }

            article.IsDeleted = false;

            _context.Articles.Add(article);
        }

        public void DeleteArticle(Article article)
        {
             article.IsDeleted = true;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.Where(x => x.IsDeleted == false).ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0 );
        }

        public void UpdateArticle(Article article)
        {
            
        }
    }
}