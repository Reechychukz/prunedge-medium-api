using Application.DTOs;
using Application.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IArticleService : IAutoDependencyService
    {
        //Task<SuccessResponse<>>
        Task<SuccessResponse<ArticleDTO>> CreateArticleDraft(CreateArticleDTO model);
        Task<string> UploadFileForArticle(Guid Id, CreateFileUploadDTO objectFile);
        Task<List<string>> UploadMutipleFiles(Guid Id, List<CreateFileUploadDTO> objectFiles);
    }
}
