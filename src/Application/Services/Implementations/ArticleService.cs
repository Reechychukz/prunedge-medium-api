using Application.DTOs;
using Application.Helpers;
using Application.Resources;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.ViewModels;
using Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    class ArticleService : IArticleService
    {
        private readonly IMapper _mapper;
        public static IWebHostEnvironment _webHostEnvironment;
        private readonly IRestErrorLocalizerService _localizer;
        private readonly IRepository<Article> _articleRepository;
        private readonly IRepository<FileUpload> _fileUploadRepository;
        public ArticleService(IMapper mapper,
            IWebHostEnvironment webHostEnvironment,
            IRestErrorLocalizerService localizer,
            IRepository<Article> articleRepository,
            IRepository<FileUpload> fileUploadRepository)
        {
            _mapper = mapper;
            _articleRepository = articleRepository;
            _localizer = localizer;
            _webHostEnvironment = webHostEnvironment;
            _fileUploadRepository = fileUploadRepository;
        }

        //public async Task<PagedResponse<IEnumerable<>>> GetArticles(ResourceParameter parameter, 
        //    string title, IUrlHelper urlHelper)
        //{
        //    if (!string.IsNullOrWhiteSpace(parameter.Search))
        //    {
        //        string search = parameter.Search.Trim();
        //    }
        //}


        /// <summary>
        /// This service method create and saves a new record of an Aticle
        /// <paramref name="model"/>
        /// </summary>
        /// <returns></returns>
        public async Task<SuccessResponse<ArticleDTO>> CreateArticleDraft(CreateArticleDTO model)
        {
            var article = _mapper.Map<Article>(model);

            await _articleRepository.AddAsync(article);
            await _articleRepository.SaveChangesAsync();

            var response = _mapper.Map<ArticleDTO>(article);

            return new SuccessResponse<ArticleDTO>
            {
                //Message = _localizer.GetLocalizedString(ERestError.CreationSuccessResponse.ToString()),
                Data = response
            };
        }

        /// <summary>
        /// Service method to upload a document for an article
        /// </summary>
        /// <param name="objectFile"></param>
        /// <returns></returns>
        public async Task<string> UploadFileForArticle(Guid Id, CreateFileUploadDTO objectFile)
        {
            var isArticleExist = await _articleRepository.ExistsAsync(x => x.Id == Id);
            if (!isArticleExist)
                throw new RestException(HttpStatusCode.NotFound, "Article does not exist");

            if (objectFile.Files.Length > 0)
            {
                string path = _webHostEnvironment.WebRootPath = "\\upload\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var uniqueValue = DateTime.UtcNow.ToString("yyyy-mm-dd-hh-mm-fffffff");
                var relativeFIlePath = Path.Combine("uploads\\", uniqueValue + objectFile.Files.FileName);
                var filePath = Path.Combine(path, relativeFIlePath);

                using (FileStream fileStream = File.Create(path + objectFile.Files.FileName))
                {
                    objectFile.Files.CopyTo(fileStream);
                    fileStream.Flush();
                    //return "Uploaded";
                }
                FileUpload fileUpload = new FileUpload();
                fileUpload.ImagePath = relativeFIlePath;
                fileUpload.InseredOn = DateTime.Now;
                fileUpload.ArticleId = Id;
                await _articleRepository.SaveChangesAsync();
                return "Save Successfully";
            }
            else
            {
                return "Not Uploaded";
            }
        }

        /// <summary>
        /// Service method to add multiple files
        /// </summary>
        /// <param name="objectFiles"></param>
        /// <returns></returns>
        public async Task <List<string>> UploadMutipleFiles(Guid Id, List<CreateFileUploadDTO> objectFiles)
        {
            List<string> uploadedfileNames = new();
            foreach (var objectFile in objectFiles)
            {
                var uploadedFileName = await UploadFileForArticle(Id, objectFile);
                uploadedfileNames.Add(uploadedFileName);
            }
            return uploadedfileNames;
        }
    }
}
