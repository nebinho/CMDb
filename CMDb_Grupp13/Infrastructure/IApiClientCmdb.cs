using System;
using System.Collections.Generic;
using System.Linq;
using CMDb_Grupp13.Models;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    public interface IApiClientCmdb
    {
        Task<T> GetTopListAsync<T>(string endpoint);
        Task<CmdbDto> GetSingleMovieAsync<CmdbDto>(string endpoint);   
    }
}
