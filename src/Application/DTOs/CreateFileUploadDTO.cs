using Microsoft.AspNetCore.Http;
using System;

namespace Application.DTOs
{
    public class CreateFileUploadDTO
    {
        public IFormFile Files { get; set; }
    }

    public class FileUploadDto
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; }
        public Guid FileItemId { get; set; }
    }
}

