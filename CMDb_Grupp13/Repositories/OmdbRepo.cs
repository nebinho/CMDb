using CMDb_Grupp13.Infrastructure;
using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public class OmdbRepo : IRepository
    {
        string s = "terminator";
        private readonly IApiClient apiClient;
        private readonly string baseEndpoint = "http://www.omdbapi.com/?s=&apikey=f97b092d";

        public OmdbRepo(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<SearchDto> GetSearchAsync() => await apiClient.GetAsync<SearchDto>($"{baseEndpoint.Insert(26, s)}");

    }
}
