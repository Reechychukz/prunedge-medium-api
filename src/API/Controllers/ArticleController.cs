using Application.DTOs;
using Application.Helpers;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    //[ApiVersion("1.0")]
    [Route("api/v1/article")]
    public class ArticleController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        public static IArticleService _articleService;
        public ArticleController(IWebHostEnvironment webHostEnvironment,
            IArticleService articleService)
        {
            _webHostEnvironment = webHostEnvironment;
            _articleService = articleService;
        }

        /// <summary>
        /// Endpoint to Create an Article
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(typeof(SuccessResponse<ArticleDTO>), 201)]
        public async Task<IActionResult> CreateArticle(CreateArticleDTO model)
        {
            var result = await _articleService.CreateArticleDraft(model);
            return Ok(result);
        }
    }
}
