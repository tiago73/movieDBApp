
using MovieDBApp.Helpers;
using MovieDBApp.Models;
using System;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    public class MovieDBService : IMovieDBService
    {
        private readonly IHttpRequest _request;

        public MovieDBService(IHttpRequest request)
        {
            _request = request;
        }

        public Task<Movie> FindByIdAsync(int movieId, string language = "en")
        {
            throw new NotImplementedException();
        }

        public async Task<SearchResponse<Movie>> GetUpcomingMoviesAsync(int pageNumber = 1, string language = "en")
        {
            var url = $"{AppSettings.ApiBaseUrl}movie/" +
        $"upcoming?api_key={AppSettings.ApiKey}" +
        $"&language={language}" +
        $"&page={pageNumber}";

            return await _request.GetAsync<SearchResponse<Movie>>(url).ConfigureAwait(false);
        }
    }
}
