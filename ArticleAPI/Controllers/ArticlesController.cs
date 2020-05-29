using ArticleAPI.Data;
using ArticleAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArticleAPI.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepo _repository;

        public ArticlesController(IArticleRepo repository)
        {
            _repository = repository;
        }
        
        [HttpGet("{id}")]
        public ActionResult <Article> GetArticleById(int id)
        {
            var articleItem = _repository.GetArticleById(id);

            return Ok(articleItem);
        }
    }
}