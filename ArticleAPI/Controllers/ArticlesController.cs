using System.Collections.Generic;
using ArticleAPI.Data;
using ArticleAPI.Dtos;
using ArticleAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ArticleAPI.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepo _repository;
        private IMapper _mapper;

        public ArticlesController(IArticleRepo repository, IMapper mapper)
        {
            _repository = repository;    
            _mapper = mapper;    
        }

        [HttpGet]
        public ActionResult <IEnumerable<ArticleReadDto>> GetAllArticles()
        {
            var articleItemList = _repository.GetAllArticles();

            return Ok(_mapper.Map<IEnumerable<ArticleReadDto>>(articleItemList));            
        }
        
        [HttpGet("{id}")]
        public ActionResult <ArticleReadDto> GetArticleById(int id)
        {
            var articleItem = _repository.GetArticleById(id);
            if(articleItem != null)
            {
                return Ok(_mapper.Map<ArticleReadDto>(articleItem));                
            }
            return NotFound();
        }
    }
}