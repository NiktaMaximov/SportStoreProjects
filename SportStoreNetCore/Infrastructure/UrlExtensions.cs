using Microsoft.AspNetCore.Http;

namespace SportStoreNetCore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest httpRequest)
        {
            var res = httpRequest.QueryString.HasValue ? $"{httpRequest.Path}{httpRequest.QueryString}" : httpRequest.Path.ToString();
            return res;
        }
    }
}
