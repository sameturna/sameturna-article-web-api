using System;
using System.Collections.Generic;
using ArticleAPI.Data;
using ArticleAPI.Dtos;
using ArticleAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArticleAPI.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepo _repository;
        private IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public ArticlesController(IArticleRepo repository, IMapper mapper, IMemoryCache memoryCache)
        {
            _repository = repository;    
            _mapper = mapper;    
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public ActionResult <IEnumerable<ArticleReadDto>> GetAllArticles()
        {
            const string cacheKey = "articleListKey";
            if (!_memoryCache.TryGetValue(cacheKey, out object articleReadDtoList))
            {
                var articleItemList = _repository.GetAllArticles();
                articleReadDtoList = _mapper.Map<IEnumerable<ArticleReadDto>>(articleItemList);

                var cacheExpirationOptions =
                new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(20),
                    Priority = CacheItemPriority.Normal
                };
                _memoryCache.Set(cacheKey, articleReadDtoList, cacheExpirationOptions);
            }

            return Ok(articleReadDtoList);            
        }
        
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult <ArticleReadDto> GetArticleById(int id)
        {
            var articleItem = _repository.GetArticleById(id);
            if(articleItem != null)
            {
                return Ok(_mapper.Map<ArticleReadDto>(articleItem));                
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <ArticleReadDto> CreateArticle(ArticleCreateDto articleCreateDto)
        {
            var ArticleModel = _mapper.Map<Article>(articleCreateDto);
            _repository.CreateArticle(ArticleModel);
            _repository.SaveChanges();

            var articleReadDto = _mapper.Map<ArticleReadDto>(ArticleModel);

            return CreatedAtRoute(nameof(GetArticleById), new { Id = ArticleModel.Id }, articleReadDto);
        }

        [HttpPut("{id}")] 
        public ActionResult UpdateArticle(int id, ArticleUpdateDto articleUpdateDto)
        {
            var articleModel = _repository.GetArticleById(id);
            if(articleModel == null)
            {
                return NotFound();
            }

            _mapper.Map(articleUpdateDto, articleModel);

            _repository.UpdateArticle(articleModel);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")] 
        public ActionResult DeleteArticle(int id)
        {
            var articleModel = _repository.GetArticleById(id);
            if(articleModel == null)
            {
                return NotFound();
            }

            _repository.DeleteArticle(articleModel);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}