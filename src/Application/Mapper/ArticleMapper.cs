using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class ArticleMapper : Profile
    {
        public ArticleMapper()
        {
            CreateMap<ArticleDTO, Article>();
            CreateMap<CreateArticleDTO, Article>();
        }
    }
}
