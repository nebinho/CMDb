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
        string s = "terminator";
        private readonly IApiClientCmdb apiClient;
        private readonly string baseEndpoint = "http://www.omdbapi.com/?apikey=f97b092d&s=";

        public OmdbRepo(IApiClientCmdb apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<SearchDto> GetSearchAsync() => await apiClient.GetAsync<SearchDto>($"{baseEndpoint}/{s}");
       
    }
}
