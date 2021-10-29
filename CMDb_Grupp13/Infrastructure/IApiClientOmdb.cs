
using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    interface IApiClientOmdb
    {
        Task<SearchDto> GetSearchAsync<SearchDto>(string endpoint);
        Task<MovieDetailsDto> GetMovieAsync<MovieDetailsDto>(string endpoint);  

    }
}
