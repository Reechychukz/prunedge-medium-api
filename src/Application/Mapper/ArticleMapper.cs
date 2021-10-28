using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class ArticleMapper : Profile
    {
        public ArticleMapper()
        {
            CreateMap<CreateArticleDTO, Article>();
            CreateMap<Article, ArticleDTO>();
        }
    }
}
