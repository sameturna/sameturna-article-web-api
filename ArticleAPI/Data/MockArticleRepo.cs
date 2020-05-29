using System.Collections.Generic;
using ArticleAPI.Models;

namespace ArticleAPI.Data
{
    public class MockArticleRepo : IArticleRepo
    {
        public Article GetArticleById(int id)
        {
            return new Article{Id=0, Header="Corona", Body="Corona bitti", IsDeleted =false};
        }
    }
}