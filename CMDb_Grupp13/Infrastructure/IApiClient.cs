using System;
using System.Collections.Generic;
using System.Linq;
using CMDb_Grupp13.Models;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string endpoint);
        Task<SearchDto> GetAsync<SearchDtoT>(string endpoint);

    }
}
