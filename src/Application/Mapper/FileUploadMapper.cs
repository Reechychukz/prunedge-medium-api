using Application.DTOs;
using AutoMapper;
using Domain.ViewModels;

namespace Application.Mapper
{
    public class FileUploadMapper : Profile
    {
        public FileUploadMapper()
        {
            CreateMap<CreateFileUploadDTO, FileUpload>();
        }
    }
}
