using CMDb_Grupp13.Infrastructure;
using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public class OmdbRepo : IRepositoryOmdb
    {
        private readonly IApiClientCmdb apiClient;
        private readonly string baseEndpoint = "http://www.omdbapi.com/?apikey=f97b092d&";
        private readonly string searchEndpoint = "s=";
        private readonly string imdbIDEndpoint = "i=";

        public OmdbRepo(IApiClientCmdb apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<SearchDto> GetSearchAsync(string searchString) => await apiClient.GetAsync<SearchDto>($"{baseEndpoint}{searchEndpoint}{searchString}");

        public async Task<MovieDetailsDto> GetMovieAsync(string imdbID) => await apiClient.GetAsync<MovieDetailsDto>($"{baseEndpoint}{imdbIDEndpoint}{imdbID}");
    }
}
