
using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    interface IApiClientOmdb
    {
        Task<SearchDto> GetAsync<SearchDtoT>(string endpoint);

    }
}
