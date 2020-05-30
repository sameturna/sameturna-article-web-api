using ArticleAPI.Dtos;
using ArticleAPI.Models;
using AutoMapper;

namespace ArticleAPI.Profiles
{
    public class ArticlesProfile : Profile
    {
        public ArticlesProfile()
        {
            CreateMap<Article, ArticleReadDto>();
        }
    }
}