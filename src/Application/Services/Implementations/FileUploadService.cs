//using Application.Services.Interfaces;
//using Domain.ViewModels;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace application.services.implementations
//{
//    public class FileUploadService : IFileUploadService
//    {
//        public static IWebHostEnvironment _webHostEnvironment;
//        public FileUploadService(IWebHostEnvironment webHostEnvironment)
//        {
//            _webHostEnvironment = webHostEnvironment;
//        }

//        /// <summary>
//        /// Service method to upload a document for an article
//        /// </summary>
//        /// <param name="objectFile"></param>
//        /// <returns></returns>
//        public string UploadFile(Guid articleId, [FromForm] FileUpload objectFile)
//        {
            
//            if (objectFile.Files.Length > 0)
//            {
//                string path = _webHostEnvironment.WebRootPath = "\\upload\\";
//                if (!Directory.Exists(path))
//                {
//                    Directory.CreateDirectory(path);
//                }
//                using (FileStream fileStream = File.Create(path + objectFile.Files.FileName))
//                {
//                    objectFile.Files.CopyTo(fileStream);
//                    fileStream.Flush();
//                    return "Uploaded";
//                }
//            }
//            else
//            {
//                return "Not Uploaded";
//            }
//        }

//        public List<string> UploadMutipleFiles(Guid id, List<FileUpload> objectFiles)
//        {
//            List<string> uploadedfileNames = new();
//            foreach (var objectFile in objectFiles)
//            {
//                var uploadedFileName = UploadFile(id, objectFile);
//                uploadedfileNames.Add(uploadedFileName);
//            }
//            return uploadedfileNames;
//        }
        
//    }
//}
