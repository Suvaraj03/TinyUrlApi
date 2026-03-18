using TinyUrlApi.DTO;
using TinyUrlApi.Entity;

namespace TinyUrlApi.Services
{
    public interface IUrlService
    {
        Task<UrlResponse> CreateShortUrlAsync(CreateUrlRequest request);
        Task<List<UrlResponse>> GetPublicUrlsAsync();
        Task<Url> GetByShortCodeAsync(string code);
        Task<bool> DeleteAsync(int id);
        Task<List<UrlResponse>> SearchAsync(string query);
    }

}
