using Application.Helpers;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IFileUploadService : IAutoDependencyService
    {
        string UploadFile(Guid articleId, [FromForm] FileUpload objectFile);
        List<string> UploadMutipleFiles(Guid id, List<FileUpload> objectFiles);
        //Task<IEnumerable<Document>> CreateGenericDocument(GenericTenderDocumentDTO documentDTO);
    }
}
