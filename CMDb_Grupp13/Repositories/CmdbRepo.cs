using CMDb_Grupp13.Infrastructure;
using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public class CmdbRepo : IRepositoryCmdb
    {
        private readonly IApiClientCmdb apiClient;
        private readonly string baseEndpoint = "https://grupp9.dsvkurs.miun.se/api/";
        private readonly string topFourEndpoint = "Toplist?sort=desc&count=4&type=ratings";
        public CmdbRepo(IApiClientCmdb apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IEnumerable<CmdbDto>> GetTopListAsync() => await apiClient.GetTopListAsync<IEnumerable<CmdbDto>>($"{baseEndpoint}{topFourEndpoint}");
        public async Task<CmdbDto> GetSingleMovieAsync(string imdbID) => await apiClient.GetSingleMovieAsync<CmdbDto>($"{baseEndpoint}{imdbID}");
        public async Task<CmdbDto> GetLikeDislikeAsync(string imdbID, string action) => await apiClient.GetLikeDislikeAsync<CmdbDto>($"{baseEndpoint}{imdbID}/{action}");   

    }
}