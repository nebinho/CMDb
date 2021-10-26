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
        private readonly string baseEndpoint = "https://grupp9.dsvkurs.miun.se/api";
        public CmdbRepo(IApiClientCmdb apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<IEnumerable<TopListDto>> GetTopListAsync() => await apiClient.GetAsync<IEnumerable<TopListDto>>($"{baseEndpoint}/TopList");

    }
}