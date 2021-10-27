using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IPhotoAccessor
    {
        Task<FileObject> AddPhoto(IFormFile photo);
        Task<FileObject> AddFile(IFormFile file);
    }
}
