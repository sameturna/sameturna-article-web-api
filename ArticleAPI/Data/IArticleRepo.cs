using System.Collections.Generic;
using ArticleAPI.Models;

namespace ArticleAPI.Data
{
    public interface IArticleRepo
    {
        IEnumerable<Article> GetAllArticles();
        Article GetArticleById(int id);
        void CreateArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(Article article);
    }
}