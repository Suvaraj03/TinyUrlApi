using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TinyUrlApi.DTO;
using TinyUrlApi.Services;

namespace TinyUrlApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly IUrlService _service;

        public UrlController(IUrlService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUrlRequest request)
        {
            var result = await _service.CreateShortUrlAsync(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetPublicUrlsAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _service.DeleteAsync(id);
            if (!success) return NotFound();

            return Ok();
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string query)
        {
            return Ok(await _service.SearchAsync(query));
        }
    }

}
