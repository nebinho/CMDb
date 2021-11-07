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

        public CmdbRepo(IApiClientCmdb apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IEnumerable<CmdbDto>> GetTopListAsync(int numberOfMovies) => await apiClient.GetTopListAsync<IEnumerable<CmdbDto>>($"{baseEndpoint}Toplist?sort=desc&count={numberOfMovies}&type=ratings");
        public async Task<CmdbDto> GetSingleMovieAsync(string imdbID) => await apiClient.GetSingleMovieAsync<CmdbDto>($"{baseEndpoint}{imdbID}");
       
    }
}