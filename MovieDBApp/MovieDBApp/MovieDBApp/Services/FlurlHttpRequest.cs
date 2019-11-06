using Flurl.Http;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    class FlurlHttpRequest : IHttpRequest
    {
        public async Task<TResult> GetAsync<TResult>(string uri)
        {
            return await uri.GetJsonAsync<TResult>();
        }
    }
}
